namespace GraphicEditor
{
    partial class FormEditor
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                graphics.Dispose();
                currentImage.Dispose();
                pencil.Dispose();
                eraser.Dispose();
                figureBackgroundBrush.Dispose();      
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.toolStripFile = new System.Windows.Forms.ToolStrip();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionNegativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCursorDefault = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPencil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.withoutFillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColor1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColor2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelPenSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxPenSize = new System.Windows.Forms.ToolStripTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSizeImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFile.SuspendLayout();
            this.toolStripMainTools.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripFile
            // 
            this.toolStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator,
            this.toolStripDropDownButtonEdit});
            this.toolStripFile.Location = new System.Drawing.Point(0, 0);
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(866, 25);
            this.toolStripFile.TabIndex = 0;
            this.toolStripFile.Text = "toolStrip1";
            // 
            // создатьToolStripButton
            // 
            this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
            this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton.Name = "создатьToolStripButton";
            this.создатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.создатьToolStripButton.Text = "&Create";
            this.создатьToolStripButton.Click += new System.EventHandler(this.создатьToolStripButton_Click);
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.открытьToolStripButton.Text = "&Open";
            this.открытьToolStripButton.Click += new System.EventHandler(this.открытьToolStripButton_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.сохранитьToolStripButton.Text = "&Save";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButtonEdit
            // 
            this.toolStripDropDownButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorCorrectionToolStripMenuItem,
            this.sharpnessToolStripMenuItem,
            this.inversionNegativeToolStripMenuItem,
            this.effectsToolStripMenuItem,
            this.grayscaleToolStripMenuItem});
            this.toolStripDropDownButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonEdit.Image")));
            this.toolStripDropDownButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonEdit.Name = "toolStripDropDownButtonEdit";
            this.toolStripDropDownButtonEdit.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButtonEdit.Text = "Edit";
            this.toolStripDropDownButtonEdit.ToolTipText = "Edit";
            // 
            // colorCorrectionToolStripMenuItem
            // 
            this.colorCorrectionToolStripMenuItem.Name = "colorCorrectionToolStripMenuItem";
            this.colorCorrectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorCorrectionToolStripMenuItem.Text = "Color correction";
            this.colorCorrectionToolStripMenuItem.Click += new System.EventHandler(this.colorCorrectionToolStripMenuItem_Click);
            // 
            // sharpnessToolStripMenuItem
            // 
            this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
            this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sharpnessToolStripMenuItem.Text = "Sharpness";
            // 
            // inversionNegativeToolStripMenuItem
            // 
            this.inversionNegativeToolStripMenuItem.Name = "inversionNegativeToolStripMenuItem";
            this.inversionNegativeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inversionNegativeToolStripMenuItem.Text = "Inversion (Negative)";
            this.inversionNegativeToolStripMenuItem.Click += new System.EventHandler(this.inversionNegativeToolStripMenuItem_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // toolStripMainTools
            // 
            this.toolStripMainTools.AutoSize = false;
            this.toolStripMainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCursorDefault,
            this.toolStripSeparator3,
            this.toolStripButtonPencil,
            this.toolStripButtonEraser,
            this.toolStripSeparator1,
            this.toolStripButtonLine,
            this.toolStripButtonEllipse,
            this.toolStripButtonRectangle,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripButtonColor1,
            this.toolStripButtonColor2,
            this.toolStripSeparator4,
            this.toolStripLabelPenSize,
            this.toolStripTextBoxPenSize});
            this.toolStripMainTools.Location = new System.Drawing.Point(0, 25);
            this.toolStripMainTools.Name = "toolStripMainTools";
            this.toolStripMainTools.Size = new System.Drawing.Size(866, 40);
            this.toolStripMainTools.TabIndex = 3;
            this.toolStripMainTools.Text = "toolStrip2";
            // 
            // toolStripButtonCursorDefault
            // 
            this.toolStripButtonCursorDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCursorDefault.Image = global::GraphicEditor.Properties.Resources.default_cursor;
            this.toolStripButtonCursorDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCursorDefault.Name = "toolStripButtonCursorDefault";
            this.toolStripButtonCursorDefault.Size = new System.Drawing.Size(23, 37);
            this.toolStripButtonCursorDefault.Text = "Cursor";
            this.toolStripButtonCursorDefault.Click += new System.EventHandler(this.toolStripButtonCursorDefault_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButtonPencil
            // 
            this.toolStripButtonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPencil.Image = global::GraphicEditor.Properties.Resources.icon_pencil;
            this.toolStripButtonPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPencil.Name = "toolStripButtonPencil";
            this.toolStripButtonPencil.Size = new System.Drawing.Size(23, 37);
            this.toolStripButtonPencil.Text = "Pencil";
            this.toolStripButtonPencil.Click += new System.EventHandler(this.toolStripButtonPencil_Click);
            // 
            // toolStripButtonEraser
            // 
            this.toolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEraser.Image = global::GraphicEditor.Properties.Resources.icon_eraser;
            this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEraser.Name = "toolStripButtonEraser";
            this.toolStripButtonEraser.Size = new System.Drawing.Size(23, 37);
            this.toolStripButtonEraser.Text = "Eraser";
            this.toolStripButtonEraser.Click += new System.EventHandler(this.toolStripButtonEraser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = global::GraphicEditor.Properties.Resources.icon_line;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(23, 37);
            this.toolStripButtonLine.Text = "Line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = global::GraphicEditor.Properties.Resources.icon_circle;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(23, 37);
            this.toolStripButtonEllipse.Text = "Ellipse";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripButtonRectangle
            // 
            this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangle.Image = global::GraphicEditor.Properties.Resources.icon_rectangle;
            this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
            this.toolStripButtonRectangle.Size = new System.Drawing.Size(23, 37);
            this.toolStripButtonRectangle.Text = "Rectangle";
            this.toolStripButtonRectangle.Click += new System.EventHandler(this.toolStripButtonRectangle_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withoutFillingToolStripMenuItem,
            this.solidColorToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(52, 37);
            this.toolStripDropDownButton1.Text = "Filling";
            // 
            // withoutFillingToolStripMenuItem
            // 
            this.withoutFillingToolStripMenuItem.Checked = true;
            this.withoutFillingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.withoutFillingToolStripMenuItem.Name = "withoutFillingToolStripMenuItem";
            this.withoutFillingToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.withoutFillingToolStripMenuItem.Text = "Without filling";
            this.withoutFillingToolStripMenuItem.Click += new System.EventHandler(this.withoutFillingToolStripMenuItem_Click);
            // 
            // solidColorToolStripMenuItem
            // 
            this.solidColorToolStripMenuItem.Checked = true;
            this.solidColorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidColorToolStripMenuItem.Name = "solidColorToolStripMenuItem";
            this.solidColorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.solidColorToolStripMenuItem.Text = "Solid color";
            this.solidColorToolStripMenuItem.Click += new System.EventHandler(this.solidColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButtonColor1
            // 
            this.toolStripButtonColor1.BackColor = System.Drawing.SystemColors.WindowText;
            this.toolStripButtonColor1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonColor1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButtonColor1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor1.Name = "toolStripButtonColor1";
            this.toolStripButtonColor1.Size = new System.Drawing.Size(49, 37);
            this.toolStripButtonColor1.Text = "Color 1";
            this.toolStripButtonColor1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButtonColor1.Click += new System.EventHandler(this.toolStripButtonColor1_Click);
            // 
            // toolStripButtonColor2
            // 
            this.toolStripButtonColor2.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButtonColor2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonColor2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripButtonColor2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColor2.Image")));
            this.toolStripButtonColor2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor2.Name = "toolStripButtonColor2";
            this.toolStripButtonColor2.Size = new System.Drawing.Size(49, 37);
            this.toolStripButtonColor2.Text = "Color 2";
            this.toolStripButtonColor2.Click += new System.EventHandler(this.toolStripButtonColor2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabelPenSize
            // 
            this.toolStripLabelPenSize.Name = "toolStripLabelPenSize";
            this.toolStripLabelPenSize.Size = new System.Drawing.Size(49, 37);
            this.toolStripLabelPenSize.Text = "Pen size";
            // 
            // toolStripTextBoxPenSize
            // 
            this.toolStripTextBoxPenSize.AutoSize = false;
            this.toolStripTextBoxPenSize.MaxLength = 4;
            this.toolStripTextBoxPenSize.Name = "toolStripTextBoxPenSize";
            this.toolStripTextBoxPenSize.Size = new System.Drawing.Size(30, 40);
            this.toolStripTextBoxPenSize.Text = "1";
            this.toolStripTextBoxPenSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPenSize_KeyPress);
            this.toolStripTextBoxPenSize.TextChanged += new System.EventHandler(this.toolStripTextBoxPenSize_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 183);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(850, 500);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCoordinate,
            this.toolStripStatusLabelSizeImg,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 248);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCoordinate
            // 
            this.toolStripStatusLabelCoordinate.AutoSize = false;
            this.toolStripStatusLabelCoordinate.Name = "toolStripStatusLabelCoordinate";
            this.toolStripStatusLabelCoordinate.Size = new System.Drawing.Size(171, 17);
            this.toolStripStatusLabelCoordinate.Text = "toolStripStatusLabelCoordinate";
            // 
            // toolStripStatusLabelSizeImg
            // 
            this.toolStripStatusLabelSizeImg.Name = "toolStripStatusLabelSizeImg";
            this.toolStripStatusLabelSizeImg.Size = new System.Drawing.Size(153, 17);
            this.toolStripStatusLabelSizeImg.Text = "toolStripStatusLabelSizeImg";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripMainTools);
            this.Controls.Add(this.toolStripFile);
            this.Name = "FormEditor";
            this.Text = "GraphicEditor";
            this.toolStripFile.ResumeLayout(false);
            this.toolStripFile.PerformLayout();
            this.toolStripMainTools.ResumeLayout(false);
            this.toolStripMainTools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripFile;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip toolStripMainTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonPencil;
        private System.Windows.Forms.ToolStripButton toolStripButtonEraser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor1;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCoordinate;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSizeImg;
        private System.Windows.Forms.ToolStripButton toolStripButtonCursorDefault;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem withoutFillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPenSize;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPenSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonEdit;
        private System.Windows.Forms.ToolStripMenuItem colorCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionNegativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
    }
}

