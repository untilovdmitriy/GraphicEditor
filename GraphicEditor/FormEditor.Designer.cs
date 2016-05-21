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
                pencil1.Dispose();
                pencil2.Dispose();
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
            this.toolStripDropDownButtonImage = new System.Windows.Forms.ToolStripDropDownButton();
            this.gammaCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueSaturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonEffects = new System.Windows.Forms.ToolStripDropDownButton();
            this.inversionNegativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonZoomMinus = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomPlus = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItemRotate90Right = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeToLeftToolStripMenuItemRotate90Left = new System.Windows.Forms.ToolStripMenuItem();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItemHorizontalFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItemVerticalFlip = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFile.SuspendLayout();
            this.toolStripMainTools.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripFile
            // 
            this.toolStripFile.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator,
            this.toolStripDropDownButtonEdit,
            this.toolStripSeparator6,
            this.toolStripDropDownButtonImage,
            this.toolStripSeparator7,
            this.toolStripDropDownButtonEffects,
            this.toolStripSeparator8,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.toolStripSeparator5,
            this.toolStripButtonZoomMinus,
            this.toolStripButtonZoomPlus});
            this.toolStripFile.Location = new System.Drawing.Point(0, 0);
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(1010, 25);
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
            // toolStripDropDownButtonImage
            // 
            this.toolStripDropDownButtonImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gammaCorrectionToolStripMenuItem,
            this.brightnessContrastToolStripMenuItem,
            this.hueSaturationToolStripMenuItem,
            this.colorBalanceToolStripMenuItem});
            this.toolStripDropDownButtonImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonImage.Image")));
            this.toolStripDropDownButtonImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonImage.Name = "toolStripDropDownButtonImage";
            this.toolStripDropDownButtonImage.Size = new System.Drawing.Size(56, 22);
            this.toolStripDropDownButtonImage.Text = "Image";
            this.toolStripDropDownButtonImage.ToolTipText = "Image";
            // 
            // gammaCorrectionToolStripMenuItem
            // 
            this.gammaCorrectionToolStripMenuItem.Name = "gammaCorrectionToolStripMenuItem";
            this.gammaCorrectionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gammaCorrectionToolStripMenuItem.Text = "Gamma correction";
            this.gammaCorrectionToolStripMenuItem.Click += new System.EventHandler(this.gammaCorrectionToolStripMenuItem_Click);
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness/Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessContrastToolStripMenuItem_Click);
            // 
            // hueSaturationToolStripMenuItem
            // 
            this.hueSaturationToolStripMenuItem.Name = "hueSaturationToolStripMenuItem";
            this.hueSaturationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.hueSaturationToolStripMenuItem.Text = "Hue/Saturation";
            this.hueSaturationToolStripMenuItem.Click += new System.EventHandler(this.hueSaturationToolStripMenuItem_Click);
            // 
            // colorBalanceToolStripMenuItem
            // 
            this.colorBalanceToolStripMenuItem.Name = "colorBalanceToolStripMenuItem";
            this.colorBalanceToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.colorBalanceToolStripMenuItem.Text = "Color balance";
            this.colorBalanceToolStripMenuItem.Click += new System.EventHandler(this.colorBalanceToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonEffects
            // 
            this.toolStripDropDownButtonEffects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonEffects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionNegativeToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.sharpnessToolStripMenuItem,
            this.blurToolStripMenuItem});
            this.toolStripDropDownButtonEffects.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonEffects.Image")));
            this.toolStripDropDownButtonEffects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonEffects.Name = "toolStripDropDownButtonEffects";
            this.toolStripDropDownButtonEffects.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButtonEffects.Text = "Effects";
            this.toolStripDropDownButtonEffects.ToolTipText = "Effects";
            // 
            // inversionNegativeToolStripMenuItem
            // 
            this.inversionNegativeToolStripMenuItem.Name = "inversionNegativeToolStripMenuItem";
            this.inversionNegativeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.inversionNegativeToolStripMenuItem.Text = "Inversion (Negative)";
            this.inversionNegativeToolStripMenuItem.Click += new System.EventHandler(this.inversionNegativeToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // sharpnessToolStripMenuItem
            // 
            this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
            this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sharpnessToolStripMenuItem.Text = "Sharpness";
            this.sharpnessToolStripMenuItem.Visible = false;
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = global::GraphicEditor.Properties.Resources.return_undo;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = global::GraphicEditor.Properties.Resources.return_redo;
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRedo.Text = "Redo";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonZoomMinus
            // 
            this.toolStripButtonZoomMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomMinus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomMinus.Image")));
            this.toolStripButtonZoomMinus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomMinus.Name = "toolStripButtonZoomMinus";
            this.toolStripButtonZoomMinus.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonZoomMinus.Text = "toolStripButtonZoomMinus";
            this.toolStripButtonZoomMinus.ToolTipText = "Zoom minus";
            this.toolStripButtonZoomMinus.Click += new System.EventHandler(this.toolStripButtonZoomMinus_Click);
            // 
            // toolStripButtonZoomPlus
            // 
            this.toolStripButtonZoomPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomPlus.Image = global::GraphicEditor.Properties.Resources.zoom_plus;
            this.toolStripButtonZoomPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomPlus.Name = "toolStripButtonZoomPlus";
            this.toolStripButtonZoomPlus.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonZoomPlus.Text = "toolStripButtonZoomPlus";
            this.toolStripButtonZoomPlus.ToolTipText = "Zoom plus";
            this.toolStripButtonZoomPlus.Click += new System.EventHandler(this.toolStripButtonZoomPlus_Click);
            // 
            // toolStripDropDownButtonEdit
            // 
            this.toolStripDropDownButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateToolStripMenuItem,
            this.flipToolStripMenuItem});
            this.toolStripDropDownButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonEdit.Image")));
            this.toolStripDropDownButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonEdit.Name = "toolStripDropDownButtonEdit";
            this.toolStripDropDownButtonEdit.Size = new System.Drawing.Size(43, 22);
            this.toolStripDropDownButtonEdit.Text = "Edit";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItemRotate90Right,
            this.degreeToLeftToolStripMenuItemRotate90Left});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // horizontalToolStripMenuItemRotate90Right
            // 
            this.horizontalToolStripMenuItemRotate90Right.Name = "horizontalToolStripMenuItemRotate90Right";
            this.horizontalToolStripMenuItemRotate90Right.Size = new System.Drawing.Size(182, 22);
            this.horizontalToolStripMenuItemRotate90Right.Text = "90 degree to right";
            this.horizontalToolStripMenuItemRotate90Right.Click += new System.EventHandler(this.horizontalToolStripMenuItemRotate90Right_Click);
            // 
            // degreeToLeftToolStripMenuItemRotate90Left
            // 
            this.degreeToLeftToolStripMenuItemRotate90Left.Name = "degreeToLeftToolStripMenuItemRotate90Left";
            this.degreeToLeftToolStripMenuItemRotate90Left.Size = new System.Drawing.Size(182, 22);
            this.degreeToLeftToolStripMenuItemRotate90Left.Text = "90 degree to left";
            this.degreeToLeftToolStripMenuItemRotate90Left.Click += new System.EventHandler(this.degreeToLeftToolStripMenuItemRotate90Left_Click);
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItemHorizontalFlip,
            this.verticalToolStripMenuItemVerticalFlip});
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.flipToolStripMenuItem.Text = "Flip";
            // 
            // horizontalToolStripMenuItemHorizontalFlip
            // 
            this.horizontalToolStripMenuItemHorizontalFlip.Name = "horizontalToolStripMenuItemHorizontalFlip";
            this.horizontalToolStripMenuItemHorizontalFlip.Size = new System.Drawing.Size(135, 22);
            this.horizontalToolStripMenuItemHorizontalFlip.Text = "Horizontal";
            this.horizontalToolStripMenuItemHorizontalFlip.Click += new System.EventHandler(this.horizontalToolStripMenuItemHorizontalFlip_Click);
            // 
            // verticalToolStripMenuItemVerticalFlip
            // 
            this.verticalToolStripMenuItemVerticalFlip.Name = "verticalToolStripMenuItemVerticalFlip";
            this.verticalToolStripMenuItemVerticalFlip.Size = new System.Drawing.Size(135, 22);
            this.verticalToolStripMenuItemVerticalFlip.Text = "Vertical";
            this.verticalToolStripMenuItemVerticalFlip.Click += new System.EventHandler(this.verticalToolStripMenuItemVerticalFlip_Click);
            // 
            // toolStripMainTools
            // 
            this.toolStripMainTools.AutoSize = false;
            this.toolStripMainTools.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.toolStripMainTools.Size = new System.Drawing.Size(1010, 46);
            this.toolStripMainTools.TabIndex = 3;
            this.toolStripMainTools.Text = "toolStrip2";
            // 
            // toolStripButtonCursorDefault
            // 
            this.toolStripButtonCursorDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCursorDefault.Image = global::GraphicEditor.Properties.Resources.default_cursor;
            this.toolStripButtonCursorDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCursorDefault.Name = "toolStripButtonCursorDefault";
            this.toolStripButtonCursorDefault.Size = new System.Drawing.Size(23, 43);
            this.toolStripButtonCursorDefault.Text = "Cursor";
            this.toolStripButtonCursorDefault.Click += new System.EventHandler(this.toolStripButtonCursorDefault_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripButtonPencil
            // 
            this.toolStripButtonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPencil.Image = global::GraphicEditor.Properties.Resources.icon_pencil;
            this.toolStripButtonPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPencil.Name = "toolStripButtonPencil";
            this.toolStripButtonPencil.Size = new System.Drawing.Size(23, 43);
            this.toolStripButtonPencil.Text = "Pencil";
            this.toolStripButtonPencil.Click += new System.EventHandler(this.toolStripButtonPencil_Click);
            // 
            // toolStripButtonEraser
            // 
            this.toolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEraser.Image = global::GraphicEditor.Properties.Resources.icon_eraser;
            this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEraser.Name = "toolStripButtonEraser";
            this.toolStripButtonEraser.Size = new System.Drawing.Size(23, 43);
            this.toolStripButtonEraser.Text = "Eraser";
            this.toolStripButtonEraser.Click += new System.EventHandler(this.toolStripButtonEraser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = global::GraphicEditor.Properties.Resources.icon_line;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(23, 43);
            this.toolStripButtonLine.Text = "Line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = global::GraphicEditor.Properties.Resources.icon_circle;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(23, 43);
            this.toolStripButtonEllipse.Text = "Ellipse";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripButtonRectangle
            // 
            this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangle.Image = global::GraphicEditor.Properties.Resources.icon_rectangle;
            this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
            this.toolStripButtonRectangle.Size = new System.Drawing.Size(23, 43);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(53, 43);
            this.toolStripDropDownButton1.Text = "Filling";
            // 
            // withoutFillingToolStripMenuItem
            // 
            this.withoutFillingToolStripMenuItem.Checked = true;
            this.withoutFillingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.withoutFillingToolStripMenuItem.Name = "withoutFillingToolStripMenuItem";
            this.withoutFillingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.withoutFillingToolStripMenuItem.Text = "Without filling";
            this.withoutFillingToolStripMenuItem.Click += new System.EventHandler(this.withoutFillingToolStripMenuItem_Click);
            // 
            // solidColorToolStripMenuItem
            // 
            this.solidColorToolStripMenuItem.Checked = true;
            this.solidColorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidColorToolStripMenuItem.Name = "solidColorToolStripMenuItem";
            this.solidColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solidColorToolStripMenuItem.Text = "Solid color";
            this.solidColorToolStripMenuItem.Click += new System.EventHandler(this.solidColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripButtonColor1
            // 
            this.toolStripButtonColor1.BackColor = System.Drawing.SystemColors.WindowText;
            this.toolStripButtonColor1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonColor1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripButtonColor1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor1.Name = "toolStripButtonColor1";
            this.toolStripButtonColor1.Size = new System.Drawing.Size(54, 43);
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
            this.toolStripButtonColor2.Size = new System.Drawing.Size(54, 43);
            this.toolStripButtonColor2.Text = "Color 2";
            this.toolStripButtonColor2.Click += new System.EventHandler(this.toolStripButtonColor2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripLabelPenSize
            // 
            this.toolStripLabelPenSize.Name = "toolStripLabelPenSize";
            this.toolStripLabelPenSize.Size = new System.Drawing.Size(56, 43);
            this.toolStripLabelPenSize.Text = "Pen size";
            // 
            // toolStripTextBoxPenSize
            // 
            this.toolStripTextBoxPenSize.AutoSize = false;
            this.toolStripTextBoxPenSize.MaxLength = 4;
            this.toolStripTextBoxPenSize.Name = "toolStripTextBoxPenSize";
            this.toolStripTextBoxPenSize.Size = new System.Drawing.Size(34, 23);
            this.toolStripTextBoxPenSize.Text = "1";
            this.toolStripTextBoxPenSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPenSize_KeyPress);
            this.toolStripTextBoxPenSize.TextChanged += new System.EventHandler(this.toolStripTextBoxPenSize_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 216);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(5, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(850, 500);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.SizeChanged += new System.EventHandler(this.pictureBoxMain_SizeChanged);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseEnter += new System.EventHandler(this.pictureBoxMain_MouseEnter);
            this.pictureBoxMain.MouseLeave += new System.EventHandler(this.pictureBoxMain_MouseLeave);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCoordinate,
            this.toolStripStatusLabelSizeImg,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1010, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCoordinate
            // 
            this.toolStripStatusLabelCoordinate.AutoSize = false;
            this.toolStripStatusLabelCoordinate.Name = "toolStripStatusLabelCoordinate";
            this.toolStripStatusLabelCoordinate.Size = new System.Drawing.Size(171, 20);
            this.toolStripStatusLabelCoordinate.Text = "toolStripStatusLabelCoordinate";
            // 
            // toolStripStatusLabelSizeImg
            // 
            this.toolStripStatusLabelSizeImg.Name = "toolStripStatusLabelSizeImg";
            this.toolStripStatusLabelSizeImg.Size = new System.Drawing.Size(153, 20);
            this.toolStripStatusLabelSizeImg.Text = "toolStripStatusLabelSizeImg";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(350, 19);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1010, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripMainTools);
            this.Controls.Add(this.toolStripFile);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormEditor";
            this.Text = "GraphicEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditor_FormClosing);
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonEffects;
        private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionNegativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonImage;
        private System.Windows.Forms.ToolStripMenuItem gammaCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueSaturationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomMinus;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomPlus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonEdit;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItemRotate90Right;
        private System.Windows.Forms.ToolStripMenuItem degreeToLeftToolStripMenuItemRotate90Left;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItemHorizontalFlip;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItemVerticalFlip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}

