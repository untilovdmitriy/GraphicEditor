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
        private static byte ToByte(int Val)
        {
            if (Val > 255) Val = 255;
            else if (Val < 0) Val = 0;
            return (byte)Val;
        }

        public static Bitmap SetGamma(Bitmap bmp, short gamma)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = Color.FromArgb(oldPixel.A,
                        ToByte(oldPixel.R + gamma),
                        ToByte(oldPixel.G + gamma),
                        ToByte(oldPixel.B + gamma));
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }

        public static Bitmap SetBrightness(Bitmap bmp, short brightness)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
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

        public static Bitmap SetContrast(Bitmap bmp, short contrast)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    Color newPixel = new Color();
                    if (contrast < 0)
                    {
                        newPixel = Color.FromArgb(oldPixel.A,
                        ToByte((oldPixel.R * (100 - contrast) + 128 * contrast) / 100),
                        ToByte((oldPixel.G * (100 - contrast) + 128 * contrast) / 100),
                        ToByte((oldPixel.B * (100 - contrast) + 128 * contrast) / 100));
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

        public static Bitmap SetSaturation(Bitmap bmp, short saturation)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
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

        public static Bitmap SetR(Bitmap bmp, short R)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
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

        public static Bitmap SetG(Bitmap bmp, short G)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
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

        public static Bitmap SetB(Bitmap bmp, short B)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
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

        public static Bitmap ToGrayscale(Bitmap bmp)
        {
            Bitmap img = new Bitmap(bmp);
            for (int x = 0; x <= img.Width - 1; x++)
            {
                for (int y = 0; y <= img.Height - 1; y += 1)
                {
                    Color oldPixel = img.GetPixel(x, y);
                    byte grayColor = ToByte((byte) (0.2125 * oldPixel.R) + (byte) (0.7154 * oldPixel.G) + (byte) (0.7154 * oldPixel.G));
                    Color newPixel = Color.FromArgb(oldPixel.A, grayColor, grayColor, grayColor);
                    img.SetPixel(x, y, newPixel);
                }
            }
            return img;
        }
    }
}
