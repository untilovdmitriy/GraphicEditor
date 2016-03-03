﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Resources;
using System.Globalization;

namespace GraphicEditor
{
    /// <summary>
    /// Написать простенький графический редактор (на WinForms), в котором будут следующие инструменты: 
    /// карандаш (произвольное рисование), 
    /// прямая линия, 
    /// прямоугольник и круг. 
    /// Редактор должен поддерживать такие возможности:
    /// - Возможность задавать цвет объекта и фон объекта (для прямоугольник и круга).
    /// - Сохранение рисунка в файл и его загрузка.
    /// - Инвертирование рисунка (в принципе любая операция над рисунком, главное, 
    /// что она должна выполняться в фоновом потоке + отображать прогресс выполнения (замедлить если сильно быстро)).
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

    public enum FillingMode
    {
        without_filling,
        solid_color
    }

    public partial class FormEditor : Form
    {
        Graphics graphics;
        Bitmap currentImage;
        Color color1, color2;
        Pen pencil1, pencil2, eraser;        
        int penSize;
        Point drawingStartPos, drawingEndPos;
        bool drawingMode, creatingNew = false;
        SolidBrush figureBackgroundBrush;
        FillingMode fillingMode;

        Tools activeTool, oldActiveTool;
        Color activeButtonColor = SystemColors.ActiveCaption;
        Color notActiveButtonColor = SystemColors.Control;

        void ClearMainWindow(Size? picSize)
        {
            if (picSize.HasValue)
            {
                currentImage = new Bitmap(picSize.Value.Width, picSize.Value.Height);
            }
            else
            {
                currentImage = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            }
            graphics = Graphics.FromImage(currentImage);
            pictureBoxMain.Image = currentImage;
            graphics.Clear(Color.White);
        }
        
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
                        this.Cursor = Cursors.Default;
                        toolStripButtonCursorDefault.BackColor = newColor;
                        break;
                    }
                case Tools.pencil:
                    {
                        this.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.pencil));
                        toolStripButtonPencil.BackColor = newColor;
                        break;
                    }
                case Tools.eraser:
                    {
                        this.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.eraser));
                        toolStripButtonEraser.BackColor = newColor;
                        break;
                    }
                case Tools.line:
                    {
                        this.Cursor = Cursors.Default;
                        toolStripButtonLine.BackColor = newColor;
                        break;
                    }
                case Tools.ellipse:
                    {
                        this.Cursor = Cursors.Default;
                        toolStripButtonEllipse.BackColor = newColor;
                        break;
                    }
                case Tools.rectangle:
                    {
                        this.Cursor = Cursors.Default;
                        toolStripButtonRectangle.BackColor = newColor;
                        break;
                    }
            }
        }

        public FormEditor(string[] arg)
        {
            InitializeComponent();
            
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            Preparing();
            OpenFile(arg[0]);
        }

        public FormEditor()
        {
            InitializeComponent();
            Preparing();           
        }

        private void Preparing()
        {
            WindowState = FormWindowState.Maximized;

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
            toolStripStatusLabelSizeImg.Text = string.Format("Size: {0} x {1} px", pictureBoxMain.Size.Width, pictureBoxMain.Size.Height);

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.jpe; *.png; *.bmp; *.gif";
            saveFileDialog1.Filter += "Jpeg (*.jpeg) |*.jpeg| Bmp (*.bmp)|*.bmp|Png (*.png)|*.png| Gif (*.gif)|*.gif";
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Do you want to save changes in current picture?", "Want to save?", MessageBoxButtons.YesNoCancel);

            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
            {
                creatingNew = true;
                сохранитьToolStripButton_Click(new object(), new EventArgs());                
            }
            else if (dlgResult == System.Windows.Forms.DialogResult.No)
            {
                CreateNew();
            }                       
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                OpenFile(openFileDialog1.FileName);
                saveFileDialog1.FileName = openFileDialog1.FileName;
            }
        }

        private void CreateNew()
        {
            CreateNewForm CNF = new CreateNewForm();
            CNF.ShowInTaskbar = false;
            if (CNF.ShowDialog() == DialogResult.OK)
            {
                ClearMainWindow(CNF.GetPicSize());
            }  
        }

        private void OpenFile(string fileName)
        {
            currentImage = new Bitmap(Image.FromFile(openFileDialog1.FileName));
            pictureBoxMain.Image = currentImage;
            graphics = Graphics.FromImage(currentImage);

            toolStripStatusLabelSizeImg.Text = string.Format("Size: {0} x {1} px", pictureBoxMain.Image.Size.Width, pictureBoxMain.Image.Size.Height);
        }

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

        private void toolStripButtonCursorDefault_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.default_cursor);
        }

        private void toolStripButtonPencil_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.pencil);
        }

        private void toolStripButtonEraser_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.eraser);
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.line);
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.ellipse);
        }

        private void toolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            ActivateTool(Tools.rectangle);
        }

        private void withoutFillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (solidColorToolStripMenuItem.Checked) solidColorToolStripMenuItem.Checked = false;
            if (!withoutFillingToolStripMenuItem.Checked) withoutFillingToolStripMenuItem.Checked = true;
            fillingMode = FillingMode.without_filling;
        }

        private void solidColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!solidColorToolStripMenuItem.Checked) solidColorToolStripMenuItem.Checked = true;
            if (withoutFillingToolStripMenuItem.Checked) withoutFillingToolStripMenuItem.Checked = false;
            fillingMode = FillingMode.solid_color;
        }

        private void toolStripButtonColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonColor1.BackColor = colorDialog1.Color;
                color1 = colorDialog1.Color;
                pencil1.Color = color1;

                if (colorDialog1.Color == Color.White) toolStripButtonColor1.ForeColor = Color.Black;
                if (colorDialog1.Color == Color.Black) toolStripButtonColor1.ForeColor = Color.White;
            }
        }

        private void toolStripButtonColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonColor2.BackColor = colorDialog1.Color;
                color2 = colorDialog1.Color;
                eraser.Color = color2;
                pencil2.Color = color2;
                figureBackgroundBrush.Color = color2;

                if (colorDialog1.Color == Color.White) toolStripButtonColor2.ForeColor = Color.Black;
                if (colorDialog1.Color == Color.Black) toolStripButtonColor2.ForeColor = Color.White;
            }
        }

        #region рисование
        /// <summary>
        /// рисование карандашом и затирание - в MouseDown и MouseMove,
        /// в MouseDown - запоминаем начальную координату, в MouseMove рисуем с начальной точки, в текущую.
        /// рисование фигур - в MouseDown и MouseUp,
        /// в MouseDown - запоминаем начальную координату, в MouseUp  - рисуем к фигуру к текущей точке.
        /// </summary>
       
        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (activeTool != Tools.default_cursor)
            {
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
            toolStripStatusLabelCoordinate.Text = string.Format("X, Y: {0}, {1} px", e.X, e.Y);

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
            if (drawingMode)
            {
                drawingEndPos = e.Location;

                float figureWidth = Math.Abs(drawingEndPos.X - drawingStartPos.X);
                float figureHeight = Math.Abs(drawingEndPos.Y - drawingStartPos.Y);
                float drawingPosX = drawingEndPos.X > drawingStartPos.X ? drawingStartPos.X : drawingEndPos.X;
                float drawingPosY = drawingEndPos.Y > drawingStartPos.Y ? drawingStartPos.Y : drawingEndPos.Y;
                int outerShift = penSize % 2 == 0 ? penSize / 2 : penSize / 2 + 1;
                int innerCircleShift = penSize % 2 == 0 ? penSize : penSize + 1;

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
            }
        }

        #endregion

        /// <summary>
        /// установка размера кисти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Incorrect pen size!");
            }
        }

        /// <summary>
        /// оставляем для ввода в поле размера кисти только цифры 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxPenSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' && ((ToolStripTextBox) sender).Text.Length <= 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        #region инверсия

        /// <summary>
        /// инверсия изображения (негатив)
        /// используем backgroundWorker1 для асинхронного вызова и отображения прогресса в toolStripProgressBar
        /// </summary>
        void Inversion()
        {
            for (int x = 0; x <= currentImage.Width - 1; x++)
            {
                for (int y = 0; y <= currentImage.Height - 1; y += 1)
                {
                    Color oldColor = currentImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    currentImage.SetPixel(x, y, newColor);
                }
                backgroundWorker1.ReportProgress((x / currentImage.Width) * 100);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Inversion();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar.Maximum = 0;
            pictureBoxMain.Image = currentImage;
        }
        
        #endregion

        private void inversionNegativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = currentImage.Width * currentImage.Height;
            toolStripProgressBar.Step = currentImage.Width;

            backgroundWorker1.RunWorkerAsync(); 
        }

        private void colorCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColorCorrection formColorCorrection = new FormColorCorrection();
            formColorCorrection.ShowInTaskbar = false;
            formColorCorrection.SetPicture(currentImage);
            
            if (formColorCorrection.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMain.Image = formColorCorrection.GetPicture();
            }           
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = ImageEditor.ToGrayscale((Bitmap) currentImage);            
        }

        private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dlgResult = MessageBox.Show("Do you want to save changes in current picture?", "Want to save?", MessageBoxButtons.YesNoCancel);

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
}
