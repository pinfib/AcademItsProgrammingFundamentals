using System;
using System.Drawing;

namespace Academits.Dorosh
{
    class GreyScaleImage
    {
        static void Main()
        {
            Bitmap image = new Bitmap("..\\..\\image.jpg");

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

            image.Save("..\\..\\out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}