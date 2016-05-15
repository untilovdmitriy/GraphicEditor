using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace GraphicEditor
{
    class ImageEditor
    {
        #region вспомогательные функции

        /// <summary>
        /// перевод int в byte, обрезаем значение если оно больше 255 и меньше 0
        /// </summary>
        private static byte ToByte(int Val)
        {
            if (Val > 255) Val = 255;
            else if (Val < 0) Val = 0;
            return (byte)Val;
        }
        private static byte ToByte(double Val)
        {
            if (Val > 255) Val = 255;
            else if (Val < 0) Val = 0;
            return (byte)Val;
        }

        #endregion

        /// <summary>
        /// делегат для применения функций цветовой коррекции
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="colorChange">изменения цвета (контраст/яркость/насыщенность/RGB каналы и пр.)</param>
        /// <returns>новый цвет пиксела</returns>
        public delegate Color ColorCorrection(Color oldPixel, short colorChange);

        /// <summary>
        /// делегат для применения эффектов (негатив, черно-белый)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <returns>новый цвет пиксела</returns>
        public delegate Color Effect(Color oldPixel);

        /// <summary>
        /// функция коррекции которая принимает делегат и его параметр
        /// </summary>
        /// <param name="bmp">изображение</param>
        /// <param name="corrector">делегат функции (гамма,яркость,контраст и пр.)</param>
        /// <param name="correctorParam">параметр (гамма,яркость,контраст и пр.)</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap Correction(Bitmap bmp, ColorCorrection corrector, short correctorParam)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = corrector.Invoke(oldPixel, correctorParam);
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        /// <summary>
        /// ф-я для применения эффектов
        /// </summary>
        /// <param name="img">старое изображение</param>
        /// <param name="effect">делегат функции эффекта (негатив, черно-белый и пр.)</param>
        /// <param name="BW">объект типа BackgroundWorker для динамического отображения процесса на прогресс-бар в отдельном потоке</param>
        public static void ApplyEffect(ref Bitmap img, Effect effect, ref BackgroundWorker BW)
        {
            // Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = (img as Bitmap).GetPixel(x, y);
                    Color newPixel = effect.Invoke(oldPixel);
                    (img as Bitmap).SetPixel(x, y, newPixel);
                }
                BW.ReportProgress((x / img.Width) * 100);
            }
            //return img;
        }

        /// <summary>
        /// гамма-коррекция
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение гаммы</param>
        /// <returns>новый цвет пиксела</returns>
        public static Color SetGamma(Color oldPixel, short gamma)
        {
            byte r = gamma < 100 ?
                ToByte(Math.Pow((oldPixel.R / 255.0), 100 - gamma) * 255)
                :
                ToByte(Math.Pow((oldPixel.R / 255.0), (double)(200 - gamma) / 100) * 255);

            byte g = gamma < 100 ?
                ToByte(Math.Pow((oldPixel.G / 255.0), 100 - gamma) * 255)
                :
                ToByte(Math.Pow((oldPixel.G / 255.0), (double)(200 - gamma) / 100) * 255);

            byte b = gamma < 100 ?
                ToByte(Math.Pow((oldPixel.B / 255.0), 100 - gamma) * 255)
                :
                ToByte(Math.Pow((oldPixel.B / 255.0), (double)(200 - gamma) / 100) * 255);

            return Color.FromArgb(oldPixel.A, r, g, b);
        }

        #region Цветовая коррекция

        /// <summary>
        /// яркость
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение яркости</param>
        /// <returns>новый цвет пиксела</returns>
        public static Color SetBrightness(Color oldPixel, short brightness)
        {
            return Color.FromArgb(oldPixel.A, ToByte(oldPixel.R + brightness), ToByte(oldPixel.G + brightness), ToByte(oldPixel.B + brightness));
        }

        /// <summary>
        /// контрастность
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение контрастности</param>
        /// <returns>новый цвет пиксела</returns>
        public static Color SetContrast(Color oldPixel, short contrast)
        {
            return
                contrast < 0 ?

                Color.FromArgb(oldPixel.A,
                ToByte((oldPixel.R * (100 + contrast) - 128 * contrast) / 100),
                ToByte((oldPixel.G * (100 + contrast) - 128 * contrast) / 100),
                ToByte((oldPixel.B * (100 + contrast) - 128 * contrast) / 100))

                :

                Color.FromArgb(oldPixel.A,
                ToByte((oldPixel.R * 100 - 128 * contrast) / (100 - contrast)),
                ToByte((oldPixel.G * 100 - 128 * contrast) / (100 - contrast)),
                ToByte((oldPixel.B * 100 - 128 * contrast) / (100 - contrast)));
        }

        /// <summary>
        /// насыщенность
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение насыщенности</param>
        /// <returns>новый цвет пиксела</returns>
        public static Color SetSaturation(Color oldPixel, short saturation)
        {
            byte R = oldPixel.R;
            byte G = oldPixel.G;
            byte B = oldPixel.B;

            double S = (Math.Max(Math.Max(R, G), B) - Math.Min(Math.Min(R, G), B)) / Math.Max(Math.Max(R, G), B);

            return Color.FromArgb(oldPixel.A, ToByte(Math.Pow(R, S)), ToByte(Math.Pow(G, S)), ToByte(Math.Pow(B, S)));
        }

        #endregion

        #region Цветовой баланс

        /// <summary>
        /// цветовой баланс (канал R)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение канала R</param>
        /// <returns>новый цвет пиксела</returns>
        public static Color SetR(Color oldPixel, short R)
        {
            return Color.FromArgb(oldPixel.A, ToByte(oldPixel.R + R), oldPixel.G, oldPixel.B);

        }

        /// <summary>
        /// цветовой баланс (канал G)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение канала G</param>
        /// <returns>новый цвет пиксела</returns>
        public static Color SetG(Color oldPixel, short G)
        {
            return Color.FromArgb(oldPixel.A, oldPixel.R, ToByte(oldPixel.G + G), oldPixel.B);
        }

        /// <summary>
        /// цветовой баланс (канал B)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение канала B</param>
        /// <returns>новый цвет пиксела</returns>
        public static Color SetB(Color oldPixel, short B)
        {
            return Color.FromArgb(oldPixel.A, oldPixel.R, oldPixel.G, ToByte(oldPixel.B + B));
        }

        #endregion

        /// <summary>
        /// Перевод в чернобелый
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <returns>цвет пиксела в оттенках серого</returns>
        public static Color ToGrayscale(Color oldPixel)
        {
            byte grayColor = ToByte(0.3 * oldPixel.R + 0.6 * oldPixel.G + 0.1 * oldPixel.G);
            return Color.FromArgb(oldPixel.A, grayColor, grayColor, grayColor);
        }

        /// <summary>
        /// инверсия (негатив)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <returns>инвертированный цвет пиксела</returns>
        public static Color Inversion(Color oldPixel)
        {
            return Color.FromArgb(oldPixel.A, 255 - oldPixel.R, 255 - oldPixel.G, 255 - oldPixel.B);
        }

        /// <summary>
        /// размытие
        /// </summary>
        /// <param name="oldPixel">старое изображение</param>
        /// <returns>размытое изображение</returns>
        public static Bitmap Blur(Bitmap bmp, ref BackgroundWorker BW)
        {
            int w = bmp.Width;
            int h = bmp.Height;

            for (int i = 1; i < w - 1; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color c1 = bmp.GetPixel(i - 1, j);
                    Color c2 = bmp.GetPixel(i, j);
                    Color c3 = bmp.GetPixel(i + 1, j);

                    byte r = (byte)((c1.R + c2.R + c3.R) / 3);
                    byte g = (byte)((c1.G + c2.G + c3.G) / 3);
                    byte b = (byte)((c1.B + c2.B + c3.B) / 3);

                    Color cBlured = Color.FromArgb(r, g, b);

                    bmp.SetPixel(i, j, cBlured);
                }
                BW.ReportProgress((i / 2 / bmp.Width) * 100);
            }
            for (int i = 0; i < w; i++)
            {
                for (int j = 1; j < h - 1; j++)
                {
                    Color c1 = bmp.GetPixel(i, j - 1);
                    Color c2 = bmp.GetPixel(i, j);
                    Color c3 = bmp.GetPixel(i, j + 1);

                    byte r = (byte)((c1.R + c2.R + c3.R) / 3);
                    byte g = (byte)((c1.G + c2.G + c3.G) / 3);
                    byte b = (byte)((c1.B + c2.B + c3.B) / 3);

                    Color cBlured = Color.FromArgb(r, g, b);

                    bmp.SetPixel(i, j, cBlured);
                }
                BW.ReportProgress((i / 2 / bmp.Width) * 100);
            }
            return bmp;
        }
    }
}
