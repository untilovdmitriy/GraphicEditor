﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Globalization;

namespace GraphicEditor
{
    /// <summary>
    /// Написать графический редактор, в котором будут следующие инструменты: 
    /// - карандаш (произвольное рисование)
    /// - ластик
    /// - прямая линия
    /// - прямоугольник и круг
    /// Редактор должен поддерживать такие возможности:
    /// - выбор 2х цветов, для карандаша, 1м рисует по ЛКМ, 2м цветом - ПКМ, 
    /// - ластик использует цвет2,
    /// - выбор режимов заливки для фигур (с заливкой и без)
    /// - при рисовании фигур, для границ используется цвет1, для внутренней заливки - цвет2
    /// - создание нового изображения (возможность задать его размер)
    /// - загрузка изображения из файла
    /// - сохранение изображения в файл в форматах JPEG/PNG/GIF/BMP
    /// - возврат к предыдущему состоянию, отмена последнего действия
    /// - возрат к последнему действию, если был возрат к предыдущему
    /// 
    /// - Инвертирование рисунка (негатив)
    /// - Перевод черно-белый режим
    /// - Цветовая коррекция:
    ///   - гамма
    ///   - яркость
    ///   - контрастность
    ///   - насыщенность
    /// - Цветовой баланс (R,G,B каналы)
    /// </summary>

    /// <summary>
    /// перечисление для выбора инструментов
    /// </summary>
    public enum Tools
    {
        default_cursor,
        pencil,
        eraser,
        line,
        ellipse,
        rectangle
    }

    /// <summary>
    /// перечисление для режимов заливки фигуры
    /// </summary>
    public enum FillingMode
    {
        without_filling,
        solid_color
    }

    public partial class FormEditor : Form
    {
        Graphics graphics;
        Bitmap currentImage, undoImage, redoImage;
        Pen pencil1, pencil2, eraser; //карандаш1 - рисует ЛКМ, карандаш2 - ПКМ, ластик (только ЛКМ)
        Color color1, color2; //цвета, которые соответсвуют карандашам
        int penSize; //размер кисти
        Point drawingStartPos, drawingEndPos; //позиции мыши для рисования
        bool drawingMode, creatingNew = false; //индикаторы для режимов рисования и режима создания нового изображения
        SolidBrush figureBackgroundBrush; //кисть для заливки фигуры
        FillingMode fillingMode; //индикатор для режимма заливки

        Tools activeTool, oldActiveTool;
        Color activeButtonColor = SystemColors.ActiveCaption;
        Color notActiveButtonColor = SystemColors.Control;

        bool IsMouseUp = true; // is the mouse up/down ?
        Point MouseDownPoint; // where the mouse was clicked
        Size ControlSize;

        double zoom = 2.0;

        /// <summary>
        /// очистка изображения
        /// </summary>
        /// <param name="picSize">задаем его размер (необязательно, размер установится согласно предыдущему размеру по умолчанию)</param>
        void ClearMainWindow(Size? picSize)
        {
            if (picSize.HasValue)
            {
                if (currentImage != null) undoImage = currentImage.Clone() as Bitmap;
                else undoImage = new Bitmap(picSize.Value.Width, picSize.Value.Height);

                currentImage = new Bitmap(picSize.Value.Width, picSize.Value.Height);
            }
            else
            {
                if (currentImage != null) undoImage = currentImage.Clone() as Bitmap;
                else undoImage = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);

                currentImage = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            }
            graphics = Graphics.FromImage(currentImage);
            pictureBoxMain.Image = currentImage;
            graphics.Clear(Color.White);

            redoImage = currentImage.Clone() as Bitmap;
        }

        #region смена активного инструмента

        /// <summary>
        /// активируем (изменяем цвет) выбранный инструмент, тот который был выбран ранее - деактивируем
        /// </summary>
        /// <param name="tool"></param>
        public void ActivateTool(Tools tool)
        {
            activeTool = tool;
            ActivateOrDeactivateTool(oldActiveTool, notActiveButtonColor);
            oldActiveTool = tool;
            ActivateOrDeactivateTool(activeTool, activeButtonColor);
        }

        /// <summary>
        /// установка активного/неактивного состояния для инструмента
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="newColor"></param>
        public void ActivateOrDeactivateTool(Tools tool, Color newColor)
        {
            switch (tool)
            {
                case Tools.default_cursor:
                    {
                        toolStripButtonCursorDefault.BackColor = newColor;
                        break;
                    }
                case Tools.pencil:
                    {
                        toolStripButtonPencil.BackColor = newColor;
                        break;
                    }
                case Tools.eraser:
                    {
                        toolStripButtonEraser.BackColor = newColor;
                        break;
                    }
                case Tools.line:
                    {
                        toolStripButtonLine.BackColor = newColor;
                        break;
                    }
                case Tools.ellipse:
                    {
                        toolStripButtonEllipse.BackColor = newColor;
                        break;
                    }
                case Tools.rectangle:
                    {
                        toolStripButtonRectangle.BackColor = newColor;
                        break;
                    }
            }
        }

        /// <summary>
        /// активация инструмента "обычный курсор"
        /// </summary>
        private void toolStripButtonCursorDefault_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.default_cursor);
        }

        /// <summary>
        /// активация инструмента "карандаш"
        /// </summary>
        private void toolStripButtonPencil_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.pencil);
        }

        /// <summary>
        /// активация инструмента "ластик"
        /// </summary>
        private void toolStripButtonEraser_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.eraser);
        }

        /// <summary>
        /// активация инструмента "линия"
        /// </summary>
        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.line);
        }

        /// <summary>
        /// активация инструмента "эллипс"
        /// </summary>
        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.ellipse);
        }

        /// <summary>
        /// активация инструмента "прямоугольник"
        /// </summary>
        private void toolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.rectangle);
        }

        #endregion

        #region смена курсора

        /// <summary>
        /// сброс курсора
        /// </summary>
        public void DeactivateCursor()
        {
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// выбор активного курсора
        /// </summary>
        public void ActivateCursor()
        {
            switch (activeTool)
            {
                case Tools.pencil:
                    {
                        this.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.pencil));
                        break;
                    }
                case Tools.eraser:
                    {
                        this.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.eraser));
                        break;
                    }
                case Tools.line:
                    {
                        this.Cursor = Cursors.Default;
                        break;
                    }
                case Tools.ellipse:
                    {
                        this.Cursor = Cursors.Default;
                        break;
                    }
                case Tools.rectangle:
                    {
                        this.Cursor = Cursors.Default;
                        break;
                    }
            }
        }

        private void pictureBoxMain_MouseEnter(object sender, EventArgs e)
        {
            ActivateCursor();
        }

        private void pictureBoxMain_MouseLeave(object sender, EventArgs e)
        {
            DeactivateCursor();
        }

        #endregion

        #region конструкторы и подготовительные действия

        /// <summary>
        /// конструктор для открытия изображений из вне, т.е. по двойному клику на изображение 
        /// </summary>
        /// <param name="arg"></param>
        public FormEditor(string[] arg)
        {
            InitializeComponent();

            ChangeCultureInfo();
            Preparing();
            OpenFile(arg[0]);
        }

        public FormEditor()
        {
            InitializeComponent();

            ChangeCultureInfo();
            Preparing();
        }

        /// <summary>
        /// смена локализации на англ.
        /// </summary>
        void ChangeCultureInfo()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        /// <summary>
        /// подготовительные действия, инициализация переменных и пр.
        /// </summary>
        private void Preparing()
        {
            WindowState = FormWindowState.Maximized; //разворачиваем приложение на весь экран

            ClearMainWindow(null);

            color1 = Color.Black;
            color2 = Color.White;
            penSize = 1;
            pencil1 = new Pen(color1, penSize);
            pencil1.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pencil1.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            pencil2 = new Pen(color2, penSize);
            pencil2.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pencil2.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            eraser = new Pen(color2, penSize);
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Square;
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            figureBackgroundBrush = new SolidBrush(color2);

            drawingMode = false;

            ActivateTool(Tools.default_cursor);

            solidColorToolStripMenuItem.Checked = false;
            withoutFillingToolStripMenuItem.Checked = true;
            fillingMode = FillingMode.without_filling;

            toolStripStatusLabelCoordinate.Text = "";
            toolStripStatusLabelSizeImg.Spring = true;
            toolStripStatusLabelSizeImg.TextAlign = ContentAlignment.MiddleLeft;

            ShowImageSize();

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.jpe; *.png; *.bmp; *.gif";
            saveFileDialog1.Filter += "Jpeg (*.jpeg) |*.jpeg|Bmp (*.bmp)|*.bmp|Png (*.png)|*.png|Gif (*.gif)|*.gif";
        }

        void ShowImageSize()
        {
            toolStripStatusLabelSizeImg.Text = string.Format("Size: {0} x {1} px", pictureBoxMain.Size.Width, pictureBoxMain.Size.Height);
        }

        #endregion

        #region Создание/Загрузка/Сохранение

        /// <summary>
        /// запрос на сохранение результатов и вызов окна для создания изображения
        /// </summary>
        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show(Messages.WANT_SAVE_QUESTION, Messages.WANT_SAVE_CAPTION, MessageBoxButtons.YesNoCancel);

            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
            {
                creatingNew = true;
                сохранитьToolStripButton_Click(new object(), new EventArgs());
            }
            else if (dlgResult == System.Windows.Forms.DialogResult.No)
            {
                CreateNew();
                ShowImageSize();
            }
        }

        /// <summary>
        /// загрузка изображения из файла
        /// </summary>
        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog1.FileName);
                saveFileDialog1.FileName = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// вызов окна для ввода размера изображения при его создании
        /// </summary>
        private void CreateNew()
        {
            CreateNewForm CNF = new CreateNewForm();
            CNF.ShowInTaskbar = false;
            if (CNF.ShowDialog() == DialogResult.OK)
            {
                ClearMainWindow(CNF.GetPicSize());
            }
        }

        /// <summary>
        /// ф-я для загрузки изображения из файла
        /// </summary>
        private void OpenFile(string fileName)
        {
            undoImage = currentImage.Clone() as Bitmap;

            currentImage = new Bitmap(Image.FromFile(openFileDialog1.FileName));
            pictureBoxMain.Image = currentImage.Clone() as Bitmap;
            graphics = Graphics.FromImage(currentImage);

            toolStripStatusLabelSizeImg.Text = string.Format("Size: {0} x {1} px", pictureBoxMain.Image.Size.Width, pictureBoxMain.Image.Size.Height);

            redoImage = currentImage.Clone() as Bitmap;
        }

        /// <summary>
        /// сохранение изображения в файл в форматах jpeg/gif/png/bmp
        /// </summary>
        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (extension)
                {
                    case ".jpeg":
                        {
                            currentImage.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                            break;
                        }
                    case ".bmp":
                        {
                            currentImage.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                            break;
                        }
                    case ".png":
                        {
                            currentImage.Save(saveFileDialog1.FileName, ImageFormat.Png);
                            break;
                        }
                    case ".gif":
                        {
                            currentImage.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                            break;
                        }
                }
            }
            if (creatingNew)
            {
                CreateNew();
                creatingNew = false;
            }
        }

        #endregion

        #region Смена цвета и режима заливки

        /// <summary>
        /// переключение на режим без заливки фигуры
        /// </summary>
        private void withoutFillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFillingMode();
        }

        /// <summary>
        /// переключение на режим заливки фигуры
        /// </summary>
        private void solidColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFillingMode();
        }

        private void SelectFillingMode()
        {
            solidColorToolStripMenuItem.Checked = !solidColorToolStripMenuItem.Checked;
            withoutFillingToolStripMenuItem.Checked = !withoutFillingToolStripMenuItem.Checked;
            if (solidColorToolStripMenuItem.Checked)
            {
                fillingMode = FillingMode.solid_color;
            }
            else if (withoutFillingToolStripMenuItem.Checked)
            {
                fillingMode = FillingMode.without_filling;
            }
        }

        /// <summary>
        /// смена цвета1
        /// </summary>
        private void toolStripButtonColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonColor1.BackColor = colorDialog1.Color;
                color1 = colorDialog1.Color;
                pencil1.Color = color1;

                if (colorDialog1.Color == Color.White)
                {
                    toolStripButtonColor1.ForeColor = Color.Black;
                }
                else if (colorDialog1.Color == Color.Black)
                {
                    toolStripButtonColor1.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// смена цвета2
        /// </summary>
        private void toolStripButtonColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonColor2.BackColor = colorDialog1.Color;
                color2 = colorDialog1.Color;
                eraser.Color = color2;
                pencil2.Color = color2;
                figureBackgroundBrush.Color = color2;

                if (colorDialog1.Color == Color.White)
                {
                    toolStripButtonColor2.ForeColor = Color.Black;
                }
                else if (colorDialog1.Color == Color.Black)
                {
                    toolStripButtonColor2.ForeColor = Color.White;
                }
            }
        }

        #endregion

        #region рисование и изменение размера полотна
        /// <summary>
        /// рисование карандашом и затирание - в MouseDown и MouseMove,
        /// в MouseDown - запоминаем начальную координату, в MouseMove рисуем с начальной точки, в текущую.
        /// рисование фигур - в MouseDown и MouseUp,
        /// в MouseDown - запоминаем начальную координату, в MouseUp  - рисуем к фигуру к текущей точке.
        /// </summary>

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Math.Abs(e.X - ((PictureBox)sender).Width) < 5) || (Math.Abs(e.Y - ((PictureBox)sender).Height) < 5))
            {
                undoImage = pictureBoxMain.Image.Clone() as Bitmap;

                IsMouseUp = false;
                ControlSize = pictureBoxMain.Size;
                MouseDownPoint = e.Location;
            }

            if (activeTool != Tools.default_cursor)
            {
                undoImage = pictureBoxMain.Image.Clone() as Bitmap;

                drawingStartPos = e.Location;
                graphics = Graphics.FromImage(pictureBoxMain.Image);
                if (activeTool == Tools.pencil && e.Button == MouseButtons.Left)
                {
                    graphics.DrawLine(pencil1, drawingStartPos.X, drawingStartPos.Y, drawingStartPos.X - 1, drawingStartPos.Y);
                }
                else if (activeTool == Tools.pencil && e.Button == MouseButtons.Right)
                {
                    graphics.DrawLine(pencil2, drawingStartPos.X, drawingStartPos.Y, drawingStartPos.X - 1, drawingStartPos.Y);
                }
                else if (activeTool == Tools.eraser && e.Button == MouseButtons.Left)
                {
                    graphics.DrawLine(eraser, drawingStartPos.X, drawingStartPos.Y, drawingStartPos.X - 1, drawingStartPos.Y);
                }
                drawingMode = true;
            }
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeTool == Tools.default_cursor)
            {
                DetectResize(e);
                if (!IsMouseUp)
                {
                    pictureBoxMain.Width = ControlSize.Width + e.X - MouseDownPoint.X;
                    pictureBoxMain.Height = ControlSize.Height + e.Y - MouseDownPoint.Y;
                    SizeChange();
                }
                toolStripStatusLabelCoordinate.Text = string.Format("X, Y: {0}, {1} px", e.X, e.Y);
            }

            if (drawingMode)
            {
                graphics = Graphics.FromImage(pictureBoxMain.Image);
                if (activeTool == Tools.pencil || activeTool == Tools.eraser)
                {
                    if (activeTool == Tools.pencil && e.Button == MouseButtons.Left)
                    {
                        graphics.DrawLine(pencil1, drawingStartPos, e.Location);
                    }
                    else if (activeTool == Tools.pencil && e.Button == MouseButtons.Right)
                    {
                        graphics.DrawLine(pencil2, drawingStartPos, e.Location);
                    }
                    else if (activeTool == Tools.eraser && e.Button == MouseButtons.Left)
                    {
                        graphics.DrawLine(eraser, drawingStartPos, e.Location);
                    }
                    drawingStartPos = e.Location;
                    pictureBoxMain.Refresh();
                }
            }
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (!IsMouseUp)
            {
                IsMouseUp = true;
                redoImage = pictureBoxMain.Image.Clone() as Bitmap;
            }

            if (drawingMode)
            {
                drawingEndPos = e.Location;

                float figureWidth = Math.Abs(drawingEndPos.X - drawingStartPos.X);
                float figureHeight = Math.Abs(drawingEndPos.Y - drawingStartPos.Y);
                float drawingPosX = drawingEndPos.X > drawingStartPos.X ? drawingStartPos.X : drawingEndPos.X;
                float drawingPosY = drawingEndPos.Y > drawingStartPos.Y ? drawingStartPos.Y : drawingEndPos.Y;
                float outerShift = penSize % 2 == 0 ? penSize / 2 : penSize / 2 + 0.5f;
                int innerCircleShift = penSize;

                switch (activeTool)
                {
                    case Tools.line:
                        {
                            if (e.Button == MouseButtons.Left)
                            {
                                graphics.DrawLine(pencil1, drawingStartPos, drawingEndPos);
                            }
                            else if (e.Button == MouseButtons.Right)
                            {
                                graphics.DrawLine(pencil2, drawingStartPos, drawingEndPos);
                            }
                            break;
                        }
                    case Tools.ellipse:
                        {
                            if (e.Button == MouseButtons.Left)
                            {
                                graphics.DrawEllipse(pencil1, drawingPosX, drawingPosY, figureWidth, figureHeight);
                            }
                            else if (e.Button == MouseButtons.Right)
                            {
                                graphics.DrawEllipse(pencil2, drawingPosX, drawingPosY, figureWidth, figureHeight);
                            }
                            if (fillingMode == FillingMode.solid_color)
                            {
                                graphics.FillEllipse(figureBackgroundBrush, drawingPosX + outerShift, drawingPosY + outerShift, figureWidth - innerCircleShift, figureHeight - innerCircleShift);
                            }
                            break;
                        }
                    case Tools.rectangle:
                        {
                            if (e.Button == MouseButtons.Left)
                            {
                                graphics.DrawRectangle(pencil1, drawingPosX, drawingPosY, figureWidth, figureHeight);
                            }
                            else if (e.Button == MouseButtons.Right)
                            {
                                graphics.DrawRectangle(pencil2, drawingPosX, drawingPosY, figureWidth, figureHeight);
                            }
                            if (fillingMode == FillingMode.solid_color)
                            {
                                graphics.FillRectangle(figureBackgroundBrush, drawingPosX + outerShift, drawingPosY + outerShift, figureWidth - penSize, figureHeight - penSize);
                            }
                            break;
                        }
                }
                pictureBoxMain.Refresh();
                drawingMode = false;

                redoImage = pictureBoxMain.Image.Clone() as Bitmap;
                currentImage = redoImage;
            }
        }

        private void DetectResize(MouseEventArgs e)
        {
            if (activeTool == Tools.default_cursor)
            {
                if (e.X > pictureBoxMain.Size.Width - 4 && e.X < pictureBoxMain.Size.Width)
                {
                    this.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.horizontal_resizer));
                }
                else if (e.Y > pictureBoxMain.Size.Height - 4 && e.Y < pictureBoxMain.Size.Height)
                {
                    this.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.vertical_resizer));
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void SizeChange()
        {
            currentImage = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            graphics = Graphics.FromImage(currentImage);
            graphics.Clear(color2);
            pictureBoxMain.Refresh();

            int w = pictureBoxMain.Image.Width < pictureBoxMain.Width ? pictureBoxMain.Image.Width : pictureBoxMain.Width;
            int h = pictureBoxMain.Image.Height < pictureBoxMain.Height ? pictureBoxMain.Image.Height : pictureBoxMain.Height;

            for (int x = 0; x <= w - 1; x++)
            {
                for (int y = 0; y <= h - 1; y += 1)
                {
                    Color oldPixel = (pictureBoxMain.Image as Bitmap).GetPixel(x, y);
                    currentImage.SetPixel(x, y, oldPixel);
                }
            }

            pictureBoxMain.Image = currentImage.Clone() as Bitmap;

            ShowImageSize();
        }

        #endregion

        #region установка размера кисти

        /// <summary>
        /// установка размера кисти
        /// </summary>
        private void toolStripTextBoxPenSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                penSize = int.Parse(toolStripTextBoxPenSize.Text);
                pencil1.Width = penSize;
                pencil2.Width = penSize;
                eraser.Width = penSize;
            }
            catch (FormatException)
            {
                MessageBox.Show(Messages.INCORRECT_PEN_SIZE);
            }
        }

        /// <summary>
        /// оставляем для ввода в поле размера кисти только цифры 
        /// </summary>
        private void toolStripTextBoxPenSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' && ((ToolStripTextBox)sender).Text.Length <= 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region эффекты

        /// <summary>
        /// используем backgroundWorker1 для асинхронного вызова функций для применения єффектов инверсии, ч/б и пр.
        /// а также отображения прогресса в toolStripProgressBar
        /// </summary>        

        private void BW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.PerformStep();
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar.Maximum = 0;
            pictureBoxMain.Image = currentImage.Clone() as Bitmap;

            redoImage = currentImage.Clone() as Bitmap;
        }

        /// <summary>
        /// негатив
        /// </summary>
        private void inversionNegativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Effect(ImageEditor.Inversion);
        }

        /// <summary>
        /// перевод в черно-белый
        /// </summary>
        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Effect(ImageEditor.ToGrayscale);
        }

        void Effect(ImageEditor.Effect effect)
        {
            currentImage = pictureBoxMain.Image.Clone() as Bitmap;

            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = currentImage.Width * currentImage.Height;
            toolStripProgressBar.Step = currentImage.Width;

            undoImage = currentImage.Clone() as Bitmap;

            BackgroundWorker BW = new BackgroundWorker();

            BW.WorkerReportsProgress = true;
            BW.WorkerSupportsCancellation = true;
            BW.DoWork += delegate(object s, DoWorkEventArgs ev)
            {
                ImageEditor.ApplyEffect(ref currentImage, effect, ref BW);
            };
            BW.ProgressChanged += BW_ProgressChanged;
            BW.RunWorkerCompleted += BW_RunWorkerCompleted;
            BW.RunWorkerAsync();
        }

        #endregion

        /// <summary>
        /// при закрытии программы выводим запрос на сохранение текущего файла
        /// </summary>
        private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (undoImage != null)
            {
                var dlgResult = MessageBox.Show(Messages.WANT_SAVE_QUESTION, Messages.WANT_SAVE_CAPTION, MessageBoxButtons.YesNoCancel);

                if (dlgResult == System.Windows.Forms.DialogResult.Yes)
                {
                    сохранитьToolStripButton_Click(new object(), new EventArgs());
                }
                else if (dlgResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        #region возврат действий

        /// <summary>
        /// возврат к предыдущему состоянию (отмена последнего действия)
        /// </summary>
        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            currentImage = redoImage;
            pictureBoxMain.Image = currentImage.Clone() as Bitmap;
            pictureBoxMain.Refresh();
        }

        /// <summary>
        /// возврат к последнему действию (если до этого делали возврат к предыдущему)
        /// </summary>
        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            currentImage = undoImage;
            pictureBoxMain.Image = currentImage.Clone() as Bitmap;
            pictureBoxMain.Refresh();
        }

        #endregion

        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallCorrecionWindow(new GammaCorrection());
        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallCorrecionWindow(new BrightnessContrast());
        }

        private void hueSaturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallCorrecionWindow(new HueSaturation());
        }

        private void colorBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallCorrecionWindow(new ColorBalance());
        }

        void CallCorrecionWindow(ICorrection window)
        {
            Form asForm = window as Form;
            asForm.ShowInTaskbar = false;
            window.SetPicture(currentImage);

            if (asForm.ShowDialog() == DialogResult.OK)
            {
                undoImage = currentImage.Clone() as Bitmap;
                pictureBoxMain.Image = window.GetPicture();
                currentImage = pictureBoxMain.Image.Clone() as Bitmap;
                redoImage = currentImage.Clone() as Bitmap;
            }
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = pictureBoxMain.Image.Clone() as Bitmap;

            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = currentImage.Width * currentImage.Height;
            toolStripProgressBar.Step = currentImage.Width;

            undoImage = currentImage.Clone() as Bitmap;

            BackgroundWorker BW = new BackgroundWorker();

            BW.WorkerReportsProgress = true;
            BW.WorkerSupportsCancellation = true;
            BW.DoWork += delegate(object s, DoWorkEventArgs ev)
            {
                currentImage = ImageEditor.Blur(pictureBoxMain.Image as Bitmap, ref BW);
            };
            BW.ProgressChanged += BW_ProgressChanged;
            BW.RunWorkerCompleted += BW_RunWorkerCompleted;
            BW.RunWorkerAsync();
        }

        private void toolStripButtonZoomPlus_Click(object sender, EventArgs e)
        {
            undoImage = currentImage.Clone() as Bitmap;
            currentImage = new Bitmap(currentImage, new Size((int)(currentImage.Width * zoom), (int)(currentImage.Height * zoom)));
            pictureBoxMain.Image = currentImage;
            redoImage = currentImage.Clone() as Bitmap;
        }

        private void toolStripButtonZoomMinus_Click(object sender, EventArgs e)
        {
            undoImage = currentImage.Clone() as Bitmap;
            currentImage = new Bitmap(currentImage, new Size((int)(currentImage.Width / zoom), (int)(currentImage.Height / zoom)));
            pictureBoxMain.Image = currentImage;
            redoImage = currentImage.Clone() as Bitmap;
        }

        private void horizontalToolStripMenuItemHorizontalFlip_Click(object sender, EventArgs e)
        {
            undoImage = currentImage.Clone() as Bitmap;
            currentImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBoxMain.Size = currentImage.Size;
            pictureBoxMain.Image = currentImage;
            redoImage = currentImage.Clone() as Bitmap;
        }

        private void verticalToolStripMenuItemVerticalFlip_Click(object sender, EventArgs e)
        {
            undoImage = currentImage.Clone() as Bitmap;
            currentImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBoxMain.Image = currentImage;
            redoImage = currentImage.Clone() as Bitmap;
        }

        private void horizontalToolStripMenuItemRotate90Right_Click(object sender, EventArgs e)
        {
            undoImage = currentImage.Clone() as Bitmap;
            currentImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxMain.Image = currentImage;
            redoImage = currentImage.Clone() as Bitmap;
        }

        private void degreeToLeftToolStripMenuItemRotate90Left_Click(object sender, EventArgs e)
        {
            undoImage = currentImage.Clone() as Bitmap;
            currentImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBoxMain.Image = currentImage;
            redoImage = currentImage.Clone() as Bitmap;
        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = pictureBoxMain.Image.Clone() as Bitmap;

            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = currentImage.Width * currentImage.Height;
            toolStripProgressBar.Step = currentImage.Width;

            undoImage = currentImage.Clone() as Bitmap;

            BackgroundWorker BW = new BackgroundWorker();

            BW.WorkerReportsProgress = true;
            BW.WorkerSupportsCancellation = true;
            BW.DoWork += delegate(object s, DoWorkEventArgs ev)
            {
                currentImage = ImageEditor.Sharpen(pictureBoxMain.Image as Bitmap, 0.5, ref BW);
            };
            BW.ProgressChanged += BW_ProgressChanged;
            BW.RunWorkerCompleted += BW_RunWorkerCompleted;
            BW.RunWorkerAsync();
        }
    }
}
