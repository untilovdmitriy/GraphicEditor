using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class ColorBalance : Form, ICorrection
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

        public ColorBalance()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarRed.Value = Convert.ToInt16(((TextBox)sender).Text);
                trackBarRed_Scroll(trackBarRed, e);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text != "-") MessageBox.Show(Messages.INCORRECT_VALUE);
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
                if (((TextBox)sender).Text != "-") MessageBox.Show(Messages.INCORRECT_VALUE);
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
                if (((TextBox)sender).Text != "-") MessageBox.Show(Messages.INCORRECT_VALUE);
            }
        }
    }
}
