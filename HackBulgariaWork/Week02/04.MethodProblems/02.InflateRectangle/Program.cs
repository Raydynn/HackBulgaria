using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _02.InflateRectangle
{
    class Program
    {
        static void Inflate(ref Rectangle rect, Size inflateSize) 
        {
            int inflateHight = inflateSize.Height;
            int inflateWidth = inflateSize.Width;

            rect.X -= inflateHight;
            rect.Y -= inflateHight;
            rect.Height += inflateHight * 2;
            rect.Width += inflateWidth * 2;

        }

        static void Main()
        {
            Rectangle rectangle = new Rectangle(4, 6, 4, 8);
            Inflate(ref rectangle, new Size(2, 2));
            Console.WriteLine(rectangle);
        }
    }
}
