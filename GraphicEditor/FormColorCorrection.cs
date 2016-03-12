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
    public partial class FormColorCorrection : Form
    {
        Image currentImage;

        public FormColorCorrection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// подтверждение, применение всех изменений по цветовой коррекции
        /// </summary>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// отмена, закрытие окна цветовой корекции
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region trackBars

        private void trackBarGamma_Scroll(object sender, EventArgs e)
        {
            textBoxGamma.Text = ((TrackBar)sender).Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetGamma, (short)((TrackBar)sender).Value);
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            textBoxBrightness.Text = ((TrackBar)sender).Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetBrightness, (short)((TrackBar)sender).Value);
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            textBoxContrast.Text = ((TrackBar)sender).Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetContrast, (short)((TrackBar)sender).Value);
        }

        private void trackBarSaturation_Scroll(object sender, EventArgs e)
        {
            textBoxSaturation.Text = trackBarSaturation.Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetSaturation, (short)((TrackBar)sender).Value);
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = ((TrackBar)sender).Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetR, (short)((TrackBar)sender).Value);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = ((TrackBar)sender).Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetG, (short)((TrackBar)sender).Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = ((TrackBar)sender).Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetB, (short)((TrackBar)sender).Value);
        }

        #endregion

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

        #region Проверка значений в полях для ввода числовых значений для цветовой коррекции

        private void textBoxGamma_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarGamma.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarGamma_Scroll(trackBarGamma, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show("Incorrect value!");
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

        private void textBoxBrightness_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarBrightness.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarBrightness_Scroll(trackBarBrightness, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show("Incorrect value!");
            }
        }

        private void textBoxContrast_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarContrast.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarContrast_Scroll(trackBarContrast, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show("Incorrect value!");
            }
        }

        private void textBoxSaturation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarSaturation.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarSaturation_Scroll(trackBarSaturation, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show("Incorrect value!");
            }
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarRed.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarRed_Scroll(trackBarRed, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show("Incorrect value!");
            }
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarGreen.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarGreen_Scroll(trackBarGreen, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show("Incorrect value!");
            }
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarBlue.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarBlue_Scroll(trackBarBlue, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show("Incorrect value!");
            }
        }

        #endregion
    }
}
