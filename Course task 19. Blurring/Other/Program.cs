using System;
using System.Drawing;

namespace Academits.Dorosh
{
    class Blurring
    {
        public static int GetColor(double color)
        {
            if(color < 0)
            {
                return 0;
            }

            if (color >255)
            {
                return 255;
            }

            return Convert.ToInt32(color);
        }

        public static Color GetColor(Bitmap image, double[,] matrix, int x, int y)
        {
            double r = 0;
            double g = 0;
            double b = 0;

            x -= matrix.GetLength(0) / 2 - 1;
            y -= matrix.GetLength(0) / 2 - 1;

            int length = matrix.GetLength(0);

            for (int i = 0; i < length; i++, y++)
            {
                if (y < 0 || y > image.Height - 1)
                {
                    continue;
                }

                for (int j = 0; j < length; j++, x++)
                {
                    if (x < 0 || x > image.Width - 1)
                    {
                        continue;
                    }

                    Color pixel = image.GetPixel(x, y);

                    r += pixel.R * matrix[i, j];
                    g += pixel.G * matrix[i, j];
                    b += pixel.B * matrix[i, j];
                }
            }

            return Color.FromArgb(GetColor(r + 128), GetColor(g + 128), GetColor(b + 128));
        }

        static void Main(string[] args)
        {
            Bitmap image = new Bitmap("..\\..\\image.jpg");

            double[,] matrix =
            {
                { 0, 1, 0},
                { -1, 0, 1},
                { 0, -1, 0}
            };

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color pixel = image.GetPixel(x, y);

                    int grayColor = Convert.ToInt32(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);

                    Color newColor = Color.FromArgb(grayColor, grayColor, grayColor);

                    image.SetPixel(x, y, newColor);
                }
            }

            image.Save("..\\..\\image2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);


            image = new Bitmap("..\\..\\image2.jpg");

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    image.SetPixel(x, y, GetColor(image, matrix, x, y));
                }
            }

            image.Save("..\\..\\image3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}