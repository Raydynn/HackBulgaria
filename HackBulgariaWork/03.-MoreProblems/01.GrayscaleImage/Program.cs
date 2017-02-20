using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace _01.GrayscaleImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bmp = (Bitmap)Image.FromFile("image.bmp");

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    int pixColor = (pixel.R + pixel.B + pixel.G) / 3;

                    Color newPixel = Color.FromArgb(pixColor, pixColor, pixColor);
                    bmp.SetPixel(i, j, newPixel);
                }
            }
            bmp.Save("newImage.bmp");
        }
    }
}
