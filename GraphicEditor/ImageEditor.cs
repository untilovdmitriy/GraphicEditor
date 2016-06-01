using System;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace GraphicEditor
{
    struct RGB
    {
        public byte R, G, B;
        public RGB(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

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
            if (Val > 255) Val = 255d;
            else if (Val < 0) Val = 0d;
            return (byte)Val;
        }

        #endregion

        /// <summary>
        /// делегат для применения функций цветовой коррекции
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="colorChange">изменения цвета (контраст/яркость/насыщенность/RGB каналы и пр.)</param>
        /// <returns>новый цвет пиксела</returns>
        public delegate RGB ColorCorrection(byte r, byte g, byte b, short colorChange);

        /// <summary>
        /// делегат для применения эффектов (негатив, черно-белый)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <returns>новый цвет пиксела</returns>
        public delegate RGB Effect(byte r, byte g, byte b);

        /// <summary>
        /// функция коррекции которая принимает делегат и его параметр
        /// </summary>
        /// <param name="bmp">изображение</param>
        /// <param name="corrector">делегат функции (гамма,яркость,контраст и пр.)</param>
        /// <param name="correctorParam">параметр (гамма,яркость,контраст и пр.)</param>
        /// <returns>измененное изображение</returns>
        public static Bitmap Correction(Bitmap img, ColorCorrection corrector, short correctorParam)
        {
            Bitmap bmp = new Bitmap(img);
            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;
            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];
            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int counter = 2; counter < rgbValues.Length; counter += 4)
            {
                RGB rgb = corrector.Invoke(rgbValues[counter - 2], rgbValues[counter - 1], rgbValues[counter], correctorParam);
                rgbValues[counter - 2] = rgb.R;
                rgbValues[counter - 1] = rgb.G;
                rgbValues[counter] = rgb.B;
            }
            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            return bmp;
        }

        /// <summary>
        /// ф-я для применения эффектов
        /// </summary>
        /// <param name="img">старое изображение</param>
        /// <param name="effect">делегат функции эффекта (негатив, черно-белый и пр.)</param>
        /// <param name="BW">объект типа BackgroundWorker для динамического отображения процесса на прогресс-бар в отдельном потоке</param>
        public static void ApplyEffect(ref Bitmap bmp, Effect effect, ref BackgroundWorker BW)
        {
            // Bitmap img = new Bitmap(bmp);
            /*
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y++)
                {
                    Color oldPixel = (img as Bitmap).GetPixel(x, y);
                    Color newPixel = ;
                    (img as Bitmap).SetPixel(x, y, newPixel);
                }
                
            }*/
            //return img;

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;
            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];
            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int counter = 2; counter < rgbValues.Length; counter += 4)
            {
                RGB rgb = effect.Invoke(rgbValues[counter - 2], rgbValues[counter - 1], rgbValues[counter]);
                rgbValues[counter - 2] = rgb.R;
                rgbValues[counter - 1] = rgb.G;
                rgbValues[counter] = rgb.B;
                //if (counter %1 == 0) BW.ReportProgress((counter / rgbValues.Length) * 100);
            }
            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            // Unlock the bits.
            bmp.UnlockBits(bmpData);
        }

        /// <summary>
        /// гамма-коррекция
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение гаммы</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetGamma(byte r, byte g, byte b, short gamma)
        {
            r = gamma < 100 ?
                ToByte(Math.Pow((r / 255.0), 100 - gamma) * 255)
                :
                ToByte(Math.Pow((r / 255.0), (double)(200 - gamma) / 100) * 255);

            g = gamma < 100 ?
                ToByte(Math.Pow((g / 255.0), 100 - gamma) * 255)
                :
                ToByte(Math.Pow((g / 255.0), (double)(200 - gamma) / 100) * 255);

            b = gamma < 100 ?
                ToByte(Math.Pow((b/ 255.0), 100 - gamma) * 255)
                :
                ToByte(Math.Pow((b / 255.0), (double)(200 - gamma) / 100) * 255);

            return new RGB(r, g, b);
        }

        #region Цветовая коррекция

        /// <summary>
        /// яркость
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение яркости</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetBrightness(byte r, byte g, byte b, short brightness)
        {
            return new RGB(ToByte(r + brightness), ToByte(g + brightness), ToByte(b + brightness));
        }

        /// <summary>
        /// контрастность
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение контрастности</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetContrast(byte r, byte g, byte b, short contrast)
        {
            return
                contrast < 0 ?

                new RGB(ToByte((r * (100 + contrast) - 128 * contrast) / 100),
                ToByte((g * (100 + contrast) - 128 * contrast) / 100),
                ToByte((b * (100 + contrast) - 128 * contrast) / 100))

                :

                new RGB(ToByte((r * 100 - 128 * contrast) / (100 - contrast)),
                ToByte((g * 100 - 128 * contrast) / (100 - contrast)),
                ToByte((b * 100 - 128 * contrast) / (100 - contrast)));
        }

        /// <summary>
        /// цветовой тон
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение насыщенности</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetHue(byte r, byte g, byte b, short hue)
        {
            double h = 0;
            double s = 0;
            double v = 0;

            RGBToHSV(r,g,b, out h, out s, out v);

            return HSVToRGB(h + hue, s, v);
        }

        /// <summary>
        /// насыщенность
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение насыщенности</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetSaturation(byte r, byte g, byte b, short saturation)
        {
            double h = 0;
            double s = 0;
            double v = 0;

            RGBToHSV(r,g,b, out h, out s, out v);

            double newSat = s + saturation / 100.0 < 0 ? 0 : s + saturation / 100.0;

            return HSVToRGB(h, newSat, v);
        }

        public static void RGBToHSV(byte r, byte g, byte b, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(r, Math.Max(g, b));
            int min = Math.Min(r, Math.Min(g, b));

            hue = Color.FromArgb(r,g,b).GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public static RGB HSVToRGB(double H, double S, double V)
        {
            int hi = Convert.ToInt32(Math.Floor(H / 60)) % 6;
            S *= 100;
            V *= 255;

            double Vmin = ((100 - S) * V) / 100;
            double alpha = (V - Vmin) * ((H % 60) / 60);
            double Vinc = Vmin + alpha;
            double Vdec = V - alpha;

            switch (hi)
            {
                case 0:
                    {
                        return new RGB(ToByte(V), ToByte(Vinc), ToByte(Vmin));
                    }
                case 1:
                    {
                        return new RGB(ToByte(Vdec), ToByte(V), ToByte(Vmin));
                    }
                case 2:
                    {
                        return new RGB(ToByte(Vmin), ToByte(V), ToByte(Vinc));
                    }
                case 3:
                    {
                        return new RGB(ToByte(Vmin), ToByte(Vdec), ToByte(V));
                    }
                case 4:
                    {
                        return new RGB(ToByte(Vinc), ToByte(Vmin), ToByte(V));
                    }
                default:
                    {
                        return new RGB(ToByte(V), ToByte(Vmin), ToByte(Vdec));
                    }
            }
        }

        #endregion

        #region Цветовой баланс

        /// <summary>
        /// цветовой баланс (канал R)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение канала R</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetR(byte r, byte g, byte b, short R)
        {
            return new RGB(ToByte(r + R), g, b);
        }

        /// <summary>
        /// цветовой баланс (канал G)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение канала G</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetG(byte r, byte g, byte b, short G)
        {
            return new RGB(r, ToByte(g + G), b);
        }

        /// <summary>
        /// цветовой баланс (канал B)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <param name="gamma">значение канала B</param>
        /// <returns>новый цвет пиксела</returns>
        public static RGB SetB(byte r, byte g, byte b, short B)
        {
            return new RGB(r, g, ToByte(b + b));
        }

        #endregion

        /// <summary>
        /// Перевод в чернобелый
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <returns>цвет пиксела в оттенках серого</returns>
        public static RGB ToGrayscale(byte r, byte g, byte b)
        {
            byte grayColor = ToByte(0.3 * r + 0.6 * g + 0.1 * b);
            return new RGB(grayColor, grayColor, grayColor);
        }

        /// <summary>
        /// инверсия (негатив)
        /// </summary>
        /// <param name="oldPixel">старый цвет пиксела</param>
        /// <returns>инвертированный цвет пиксела</returns>
        public static RGB Inversion(byte r, byte g, byte b)
        {
            return new RGB(ToByte(255 -  r), ToByte(255 - g), ToByte(255 - b));
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

        /// <summary>
        /// Sharpens the specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="strength">The strength.</param>
        /// <returns></returns>
        public static Bitmap Sharpen(Image image, double strength, ref BackgroundWorker BW)
        {
            using (var bitmap = image as Bitmap)
            {
                if (bitmap != null)
                {
                    var sharpenImage = bitmap.Clone() as Bitmap;

                    int width = image.Width;
                    int height = image.Height;

                    // Create sharpening filter.
                    const int filterSize = 5;

                    var filter = new double[,]
                {
                    {-1, -1, -1, -1, -1},
                    {-1,  2,  2,  2, -1},
                    {-1,  2, 16,  2, -1},
                    {-1,  2,  2,  2, -1},
                    {-1, -1, -1, -1, -1}
                };

                    double bias = 1.0 - strength;
                    double factor = strength / 16.0;

                    const int s = filterSize / 2;

                    var result = new Color[image.Width, image.Height];

                    // Lock image bits for read/write.
                    if (sharpenImage != null)
                    {
                        BitmapData pbits = sharpenImage.LockBits(new Rectangle(0, 0, width, height),
                                                                    ImageLockMode.ReadWrite,
                                                                    PixelFormat.Format24bppRgb);

                        // Declare an array to hold the bytes of the bitmap.
                        int bytes = pbits.Stride * height;
                        var rgbValues = new byte[bytes];

                        // Copy the RGB values into the array.
                        Marshal.Copy(pbits.Scan0, rgbValues, 0, bytes);

                        int rgb;
                        // Fill the color array with the new sharpened color values.
                        for (int x = s; x < width - s; x++)
                        {
                            for (int y = s; y < height - s; y++)
                            {
                                double red = 0.0, green = 0.0, blue = 0.0;

                                for (int filterX = 0; filterX < filterSize; filterX++)
                                {
                                    for (int filterY = 0; filterY < filterSize; filterY++)
                                    {
                                        int imageX = (x - s + filterX + width) % width;
                                        int imageY = (y - s + filterY + height) % height;

                                        rgb = imageY * pbits.Stride + 3 * imageX;

                                        red += rgbValues[rgb + 2] * filter[filterX, filterY];
                                        green += rgbValues[rgb + 1] * filter[filterX, filterY];
                                        blue += rgbValues[rgb + 0] * filter[filterX, filterY];
                                    }

                                    rgb = y * pbits.Stride + 3 * x;

                                    int r = Math.Min(Math.Max((int)(factor * red + (bias * rgbValues[rgb + 2])), 0), 255);
                                    int g = Math.Min(Math.Max((int)(factor * green + (bias * rgbValues[rgb + 1])), 0), 255);
                                    int b = Math.Min(Math.Max((int)(factor * blue + (bias * rgbValues[rgb + 0])), 0), 255);

                                    result[x, y] = Color.FromArgb(r, g, b);
                                }
                            }
                            BW.ReportProgress((x / 2 / width) * 100);
                        }

                        // Update the image with the sharpened pixels.
                        for (int x = s; x < width - s; x++)
                        {
                            for (int y = s; y < height - s; y++)
                            {
                                rgb = y * pbits.Stride + 3 * x;

                                rgbValues[rgb + 2] = result[x, y].R;
                                rgbValues[rgb + 1] = result[x, y].G;
                                rgbValues[rgb + 0] = result[x, y].B;
                            }
                            BW.ReportProgress((x / 2 / width) * 100);
                        }

                        // Copy the RGB values back to the bitmap.
                        Marshal.Copy(rgbValues, 0, pbits.Scan0, bytes);
                        // Release image bits.
                        sharpenImage.UnlockBits(pbits);
                    }

                    return sharpenImage;
                }
            }
            return null;
        }
    }
}
