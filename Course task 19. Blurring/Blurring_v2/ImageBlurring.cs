using System;
using System.Drawing;

namespace Academits.Dorosh
{
    class ImageBlurring
    {
        public static int GetColorComponent(double color)
        {
            if (color < 0)
            {
                return 0;
            }

            if (color > 255)
            {
                return 255;
            }

            return Convert.ToInt32(Math.Round(color));
        }

        public static Color GetColor(Bitmap image, double[,] matrix, int x, int y)
        {
            double r = 0;
            double g = 0;
            double b = 0;

            int length = matrix.GetLength(0);

            int radius = matrix.GetLength(0) / 2;

            for (int i = -radius, n = 0; n < length; i++, n++)
            {
                for (int j = -radius, m = 0; m < length; j++, m++)
                {
                    Color pixel = image.GetPixel(x + j, y + i);

                    r += pixel.R * matrix[n, m];
                    g += pixel.G * matrix[n, m];
                    b += pixel.B * matrix[n, m];
                }
            }

            return Color.FromArgb(GetColorComponent(r), GetColorComponent(g), GetColorComponent(b));
        }

        static void Main(string[] args)
        {
            Bitmap inputImage = new Bitmap("..\\..\\image.jpg");
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            double coefficient = 1.0 / 9;

            double[,] matrix =
            {
                { coefficient, coefficient, coefficient},
                { coefficient, coefficient, coefficient},
                { coefficient, coefficient, coefficient}
            };

            /*double coefficient = 1.0 / 25;

             double[,] matrix =
             {
                 { coefficient, coefficient, coefficient, coefficient, coefficient},
                 { coefficient, coefficient, coefficient, coefficient, coefficient},
                 { coefficient, coefficient, coefficient, coefficient, coefficient},
                 { coefficient, coefficient, coefficient, coefficient, coefficient},
                 { coefficient, coefficient, coefficient, coefficient, coefficient}
             };*/

            int radius = matrix.GetLength(0) / 2;

            int yTopBorder = inputImage.Height - radius;
            int xTopBorder = inputImage.Width - radius;

            for (int y = radius; y < yTopBorder; y++)
            {
                for (int x = radius; x < xTopBorder; x++)
                {
                    outputImage.SetPixel(x, y, GetColor(inputImage, matrix, x, y));
                }
            }

            outputImage.Save("..\\..\\out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}