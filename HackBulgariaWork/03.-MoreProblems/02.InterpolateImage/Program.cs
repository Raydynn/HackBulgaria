using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _02.InterpolateImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bmp = (Bitmap)Image.FromFile("image.bmp");
            Bitmap resized = new Bitmap(1000, 1000);

            double widthRatio = (double)resized.Width / bmp.Width;
            double heightRatio = (double)resized.Height / bmp.Height;

            for (int i = 0; i < resized.Height-1; i++)
            {
                for (int j = 0; j < resized.Width-1; j++)
                {
                    double newI = i / heightRatio;
                    double newJ = j / widthRatio;
                    Color pixel = bmp.GetPixel((int)Math.Round(newI), (int)Math.Round(newJ));
                    resized.SetPixel(i, j, pixel);
                }
            }
            resized.Save("newImage.bmp");
        }
    }
}
