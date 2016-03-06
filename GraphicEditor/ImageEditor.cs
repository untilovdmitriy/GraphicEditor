using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicEditor
{
    class ImageEditor
    {
        /// <summary>
        /// перевод int в byte, обрезаем значение если оно больше 255
        /// </summary>
        private static byte ToByte(int Val)
        {
            if (Val > 255) Val = 255;
            else if (Val < 0) Val = 0;
            return (byte) Val;
        }
        private static byte ToByte(double Val)
        {
            if (Val > 255) Val = 255;
            else if (Val < 0) Val = 0;
            return (byte) Val;
        }

        /// <summary>
        /// Гамма-коррекция
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <param name="gamma">значение гаммы</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap SetGamma(Bitmap bmp, short gamma)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);

                    byte r = gamma < 100 ? 
                        ToByte(Math.Pow((oldPixel.R / 255.0), 100 - gamma) * 255) 
                        : ToByte(Math.Pow((oldPixel.R / 255.0), (double) (200 - gamma) / 100) * 255);

                    byte g = gamma < 100 ?
                        ToByte(Math.Pow((oldPixel.G / 255.0), 100 - gamma) * 255)
                        : ToByte(Math.Pow((oldPixel.G / 255.0), (double)(200 - gamma) / 100) * 255);

                    byte b = gamma < 100 ?
                        ToByte(Math.Pow((oldPixel.B / 255.0), 100 - gamma) * 255)
                        : ToByte(Math.Pow((oldPixel.B / 255.0), (double)(200 - gamma) / 100) * 255);
                     
                    Color newPixel = Color.FromArgb(oldPixel.A, r, g, b);
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        #region Цветовая коррекция

        /// <summary>
        /// Яркость
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <param name="gamma">значение яркости</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap SetBrightness(Bitmap bmp, short brightness)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(oldPixel.A,
                        ToByte(oldPixel.R + brightness),
                        ToByte(oldPixel.G + brightness),
                        ToByte(oldPixel.B + brightness));
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        /// <summary>
        /// Контрастность
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <param name="gamma">значение контрастности</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap SetContrast(Bitmap bmp, short contrast)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = new Color();
                    if (contrast < 0)
                    {
                        newPixel = Color.FromArgb(oldPixel.A,
                        ToByte((oldPixel.R * (100 + contrast) - 128 * contrast) / 100),
                        ToByte((oldPixel.G * (100 + contrast) - 128 * contrast) / 100),
                        ToByte((oldPixel.B * (100 + contrast) - 128 * contrast) / 100));
                    }
                    else if (contrast > 0)
                    {
                        newPixel = Color.FromArgb(oldPixel.A,
                        ToByte((oldPixel.R * 100 - 128 * contrast) / (100 - contrast)),
                        ToByte((oldPixel.G * 100 - 128 * contrast) / (100 - contrast)),
                        ToByte((oldPixel.B * 100 - 128 * contrast) / (100 - contrast)));
                    }
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        /// <summary>
        /// Насыщенность
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <param name="gamma">значение насыщенности</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap SetSaturation(Bitmap bmp, short saturation)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {

                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(oldPixel.A,
                        ToByte((oldPixel.R + oldPixel.R * (saturation / 100))),
                        ToByte((oldPixel.G + oldPixel.G * (saturation / 100))),
                        ToByte((oldPixel.B + oldPixel.B * (saturation / 100))));
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        #endregion

        #region Цветовой баланс

        /// <summary>
        /// Цветовой баланс (канал R)
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <param name="gamma">значение канала R</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap SetR(Bitmap bmp, short R)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);                    
                    Color newPixel = Color.FromArgb(oldPixel.A,
                        ToByte(oldPixel.R + R),
                        oldPixel.G,
                        oldPixel.B);
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        /// <summary>
        /// Цветовой баланс (канал G)
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <param name="gamma">значение канала G</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap SetG(Bitmap bmp, short G)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(oldPixel.A,
                        oldPixel.R,
                        ToByte(oldPixel.G + G),
                        oldPixel.B);
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        /// <summary>
        /// Цветовой баланс (канал B)
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <param name="gamma">значение канала B</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap SetB(Bitmap bmp, short B)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(oldPixel.A,
                        oldPixel.R,
                        oldPixel.G,
                        ToByte(oldPixel.B + B));
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        #endregion

        /// <summary>
        /// Перевод в чернобелый
        /// </summary>
        /// <param name="bmp">изображение для изменения</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap ToGrayscale(Bitmap bmp)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    byte grayColor = ToByte((byte) (0.3 * oldPixel.R) + (byte) (0.6 * oldPixel.G) + (byte) (0.1 * oldPixel.G));
                    Color newPixel = Color.FromArgb(oldPixel.A, grayColor, grayColor, grayColor);
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }
    }
}
