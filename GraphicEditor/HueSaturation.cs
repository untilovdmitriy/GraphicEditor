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
    public partial class HueSaturation : Form
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

        public HueSaturation()
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

        private void trackBarSaturation_Scroll(object sender, EventArgs e)
        {
            textBoxSaturation.Text = trackBarSaturation.Value.ToString();
            pictureBoxMini.Image = ImageEditor.Correction((Bitmap)currentImage, ImageEditor.SetSaturation, (short)((TrackBar)sender).Value);
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
                if (((TextBox)sender).Text != "-") MessageBox.Show(Messages.INCORRECT_VALUE);
            }
        }
    }
}
