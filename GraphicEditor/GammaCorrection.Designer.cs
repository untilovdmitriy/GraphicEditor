namespace GraphicEditor
{
    partial class GammaCorrection
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxGamma);
            this.groupBox5.Controls.Add(this.trackBarGamma);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(46, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 46);
            this.groupBox5.TabIndex = 13;
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
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(46, 207);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(162, 45);
            this.buttonApply.TabIndex = 15;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(217, 207);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 45);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Location = new System.Drawing.Point(100, 12);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(226, 137);
            this.pictureBoxMini.TabIndex = 16;
            this.pictureBoxMini.TabStop = false;
            // 
            // GammaCorrection
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(420, 266);
            this.Controls.Add(this.pictureBoxMini);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GammaCorrection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GammaCorrection";
            this.TopMost = true;
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxMini;
    }
}