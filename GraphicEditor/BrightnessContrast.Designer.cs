namespace GraphicEditor
{
    partial class BrightnessContrast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxContrast);
            this.groupBox3.Controls.Add(this.trackBarContrast);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(46, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 45);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contrast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(317, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "%";
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxContrast.Location = new System.Drawing.Point(291, 20);
            this.textBoxContrast.MaxLength = 3;
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.Size = new System.Drawing.Size(26, 24);
            this.textBoxContrast.TabIndex = 8;
            this.textBoxContrast.Text = "0";
            this.textBoxContrast.TextChanged += new System.EventHandler(this.textBoxContrast_TextChanged);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarContrast.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarContrast.Location = new System.Drawing.Point(3, 20);
            this.trackBarContrast.Maximum = 99;
            this.trackBarContrast.Minimum = -99;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(288, 22);
            this.trackBarContrast.TabIndex = 7;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBrightness);
            this.groupBox2.Controls.Add(this.trackBarBrightness);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(46, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 45);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brightness";
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxBrightness.Location = new System.Drawing.Point(291, 18);
            this.textBoxBrightness.MaxLength = 4;
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.Size = new System.Drawing.Size(38, 24);
            this.textBoxBrightness.TabIndex = 7;
            this.textBoxBrightness.Text = "0";
            this.textBoxBrightness.TextChanged += new System.EventHandler(this.textBoxBrightness_TextChanged);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarBrightness.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarBrightness.Location = new System.Drawing.Point(3, 20);
            this.trackBarBrightness.Maximum = 255;
            this.trackBarBrightness.Minimum = -255;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(288, 22);
            this.trackBarBrightness.TabIndex = 6;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(46, 257);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(162, 45);
            this.buttonApply.TabIndex = 17;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(217, 257);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 45);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Location = new System.Drawing.Point(100, 12);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(226, 137);
            this.pictureBoxMini.TabIndex = 18;
            this.pictureBoxMini.TabStop = false;
            // 
            // BrightnessContrast
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(420, 317);
            this.Controls.Add(this.pictureBoxMini);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrightnessContrast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrightnessContrast";
            this.TopMost = true;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxMini;
    }
}