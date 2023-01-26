using System;
using System.Drawing;

namespace Academits.Dorosh
{
    class BlurringImage
    {
        public static int ConvertToColor(double color)
        {
            if (color < 0)
            {
                return 0;
            }

            if (color > 255)
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



            int matrixLength = matrix.GetLength(0) / 2;

            int length = matrix.GetLength(0);

            x = x - matrixLength;
            y = y - matrixLength;

            for (int i = 0; i < length; i++, x++)
            {
                for (int j = 0; j < length; j++, y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    r += pixel.R * matrix[i, j];
                    g += pixel.G * matrix[i, j];
                    b += pixel.B * matrix[i, j];
                }
            }

            return Color.FromArgb(ConvertToColor(r), ConvertToColor(g), ConvertToColor(b));
        }

        static void Main(string[] args)
        {
            Bitmap image = new Bitmap("..\\..\\image.jpg");
            Bitmap image2 = new Bitmap(image.Width, image.Height);
            image2.Save("..\\..\\image2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            double n = 1.0 / 9;

            double[,] matrix =
            {
                { n, n, n},
                { n, n, n},
                { n, n, n}
             };

            //int matrixLength = matrix.GetLength(0) / 2;
            int matrixLength = 2;

            int height = image.Height - 6;
            int width = image.Width - 6;

            for (int y = matrixLength; y < height; y++)
            {
                for (int x = matrixLength; x < width; x++)
                {
                    image2.SetPixel(x, y, GetColor(image, matrix, x, y));
                }
            }

            image2.Save("..\\..\\out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}