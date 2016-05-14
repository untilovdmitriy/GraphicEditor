namespace GraphicEditor
{
    partial class ColorBalance
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
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(46, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color balance";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(311, 107);
            this.textBoxBlue.MaxLength = 4;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(38, 24);
            this.textBoxBlue.TabIndex = 14;
            this.textBoxBlue.Text = "0";
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(311, 67);
            this.textBoxGreen.MaxLength = 4;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(38, 24);
            this.textBoxGreen.TabIndex = 13;
            this.textBoxGreen.Text = "0";
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(311, 25);
            this.textBoxRed.MaxLength = 4;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(38, 24);
            this.textBoxRed.TabIndex = 12;
            this.textBoxRed.Text = "0";
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
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
            // pictureBoxMini
            // 
            this.pictureBoxMini.Location = new System.Drawing.Point(100, 12);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(226, 137);
            this.pictureBoxMini.TabIndex = 24;
            this.pictureBoxMini.TabStop = false;
            // 
            // buttonApply
            // 
            this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonApply.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(46, 307);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(173, 45);
            this.buttonApply.TabIndex = 26;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(232, 307);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(173, 45);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ColorBalance
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(448, 362);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBoxMini);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorBalance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}