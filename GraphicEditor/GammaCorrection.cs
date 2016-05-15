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
    public partial class GammaCorrection : Form, ICorrection
    {
        Image currentImage;

        /// <summary>
        /// передаем изображение из главного окна в окно миниатюры, 
        /// для динамического отображения изменений цветовой коррекции
        /// </summary>
        /// <param name="img">изображение</param>
        public void SetPicture(Image img)
        {
            pictureBoxMini.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMini.Image = img;
            currentImage = new Bitmap(img);//, pictureBoxMini.Size);
        }

        /// <summary>
        /// возврат измененного изображения
        /// </summary>
        /// <returns>измененное изображения</returns>
        public Image GetPicture()
        {
            return pictureBoxMini.Image;
        }

        public GammaCorrection()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void trackBarGamma_Scroll(object sender, EventArgs e)
        {            
            textBoxGamma.Text = ((TrackBar)sender).Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetGamma, (short)((TrackBar)sender).Value);       
        }

        #region Проверка значений в полях для ввода числовых значений

        private void textBoxGamma_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarGamma.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarGamma_Scroll(trackBarGamma, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show(Messages.INCORRECT_VALUE);
            }
        }

        private void textBoxGamma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                if ((((TextBox)sender).Text.Length > 0))
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
