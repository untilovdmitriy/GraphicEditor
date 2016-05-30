namespace GraphicEditor
{
    partial class HueSaturation
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
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSaturation = new System.Windows.Forms.TextBox();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxHue = new System.Windows.Forms.TextBox();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Location = new System.Drawing.Point(100, 12);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(226, 137);
            this.pictureBoxMini.TabIndex = 23;
            this.pictureBoxMini.TabStop = false;
            // 
            // buttonApply
            // 
            this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonApply.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(46, 257);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(162, 45);
            this.buttonApply.TabIndex = 22;
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
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSaturation);
            this.groupBox4.Controls.Add(this.trackBarSaturation);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(46, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 45);
            this.groupBox4.TabIndex = 24;
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
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSaturation.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarSaturation.Location = new System.Drawing.Point(3, 20);
            this.trackBarSaturation.Maximum = 100;
            this.trackBarSaturation.Minimum = -100;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(288, 22);
            this.trackBarSaturation.TabIndex = 8;
            this.trackBarSaturation.Scroll += new System.EventHandler(this.trackBarSaturation_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHue);
            this.groupBox1.Controls.Add(this.trackBarHue);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 45);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hue";
            // 
            // textBoxHue
            // 
            this.textBoxHue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxHue.Location = new System.Drawing.Point(291, 18);
            this.textBoxHue.MaxLength = 4;
            this.textBoxHue.Name = "textBoxHue";
            this.textBoxHue.Size = new System.Drawing.Size(38, 24);
            this.textBoxHue.TabIndex = 9;
            this.textBoxHue.Text = "0";
            this.textBoxHue.TextChanged += new System.EventHandler(this.textBoxHue_TextChanged);
            // 
            // trackBarHue
            // 
            this.trackBarHue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarHue.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarHue.Location = new System.Drawing.Point(3, 20);
            this.trackBarHue.Maximum = 170;
            this.trackBarHue.Minimum = -180;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(288, 22);
            this.trackBarHue.TabIndex = 8;
            this.trackBarHue.Scroll += new System.EventHandler(this.trackBarHue_Scroll);
            // 
            // HueSaturation
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(420, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBoxMini);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HueSaturation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HueSaturation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxSaturation;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxHue;
        private System.Windows.Forms.TrackBar trackBarHue;

    }
}