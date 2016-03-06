namespace GraphicEditor
{
    partial class FormColorCorrection
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSaturation = new System.Windows.Forms.TextBox();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(527, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(176, 45);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(347, 309);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(176, 45);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBlue);
            this.groupBox1.Controls.Add(this.textBoxGreen);
            this.groupBox1.Controls.Add(this.textBoxRed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBarBlue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBarGreen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarRed);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(347, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color balance";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(318, 107);
            this.textBoxBlue.MaxLength = 4;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(38, 24);
            this.textBoxBlue.TabIndex = 14;
            this.textBoxBlue.Text = "0";
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            this.textBoxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(318, 67);
            this.textBoxGreen.MaxLength = 4;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(38, 24);
            this.textBoxGreen.TabIndex = 13;
            this.textBoxGreen.Text = "0";
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            this.textBoxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(318, 25);
            this.textBoxRed.MaxLength = 4;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(38, 24);
            this.textBoxRed.TabIndex = 12;
            this.textBoxRed.Text = "0";
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "B:";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarBlue.Location = new System.Drawing.Point(25, 96);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Minimum = -255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(280, 45);
            this.trackBarBlue.TabIndex = 10;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "G:";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarGreen.Location = new System.Drawing.Point(25, 62);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Minimum = -255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(280, 45);
            this.trackBarGreen.TabIndex = 8;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "R:";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarRed.Location = new System.Drawing.Point(25, 19);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Minimum = -255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(280, 45);
            this.trackBarRed.TabIndex = 6;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBrightness);
            this.groupBox2.Controls.Add(this.trackBarBrightness);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 45);
            this.groupBox2.TabIndex = 9;
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
            this.textBoxBrightness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxContrast);
            this.groupBox3.Controls.Add(this.trackBarContrast);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 45);
            this.groupBox3.TabIndex = 10;
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
            this.textBoxContrast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSaturation);
            this.groupBox4.Controls.Add(this.trackBarSaturation);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 45);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saturation";
            // 
            // textBoxSaturation
            // 
            this.textBoxSaturation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxSaturation.Location = new System.Drawing.Point(291, 18);
            this.textBoxSaturation.MaxLength = 4;
            this.textBoxSaturation.Name = "textBoxSaturation";
            this.textBoxSaturation.Size = new System.Drawing.Size(38, 24);
            this.textBoxSaturation.TabIndex = 9;
            this.textBoxSaturation.Text = "0";
            this.textBoxSaturation.TextChanged += new System.EventHandler(this.textBoxSaturation_TextChanged);
            this.textBoxSaturation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSaturation.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarSaturation.Location = new System.Drawing.Point(3, 20);
            this.trackBarSaturation.Maximum = 255;
            this.trackBarSaturation.Minimum = -255;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(288, 22);
            this.trackBarSaturation.TabIndex = 8;
            this.trackBarSaturation.Scroll += new System.EventHandler(this.trackBarSaturation_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxGamma);
            this.groupBox5.Controls.Add(this.trackBarGamma);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 46);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gamma";
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxGamma.Location = new System.Drawing.Point(291, 19);
            this.textBoxGamma.MaxLength = 4;
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(38, 24);
            this.textBoxGamma.TabIndex = 8;
            this.textBoxGamma.Text = "100";
            this.textBoxGamma.TextChanged += new System.EventHandler(this.textBoxGamma_TextChanged);
            this.textBoxGamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarGamma.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarGamma.Location = new System.Drawing.Point(3, 20);
            this.trackBarGamma.Maximum = 200;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(288, 23);
            this.trackBarGamma.TabIndex = 6;
            this.trackBarGamma.Value = 100;
            this.trackBarGamma.Scroll += new System.EventHandler(this.trackBarGamma_Scroll);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Location = new System.Drawing.Point(213, 12);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(282, 137);
            this.pictureBoxMini.TabIndex = 13;
            this.pictureBoxMini.TabStop = false;
            // 
            // FormColorCorrection
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(718, 364);
            this.Controls.Add(this.pictureBoxMini);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormColorCorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormColorCorrection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.TextBox textBoxSaturation;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.Label label1;

    }
}