using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class CreateNewForm : Form
    {
        public CreateNewForm()
        {
            InitializeComponent();
        }

        public Size GetPicSize()
        {
            return new Size(Convert.ToInt32(textBoxHorizontal.Text), Convert.ToInt32(textBoxVertical.Text));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxHorizontal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxHorizontal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int res = Int32.Parse(((TextBox)sender).Text);
                if (res <= 0) throw new Exception();
                buttonOK.Enabled = true;
            }
            catch (Exception)
            {
                buttonOK.Enabled = false;
                MessageBox.Show("Incorrect size!");
            }
        }
    }
}
