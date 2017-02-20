using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Point 
    {
        private int pointX;
        private int pointY;
        public int PointX { get; set; }
        public int PointY { get; set; }
    }
    public abstract class Shape
    {
        public abstract int GetPerimeter();
        public abstract int GetArea();
    }
    public class Rectangle : Shape
    {
        private int width;
        private int height;
        private int center;

        public int Width { get; set; }
        public int Height { get; set; }
        public int Center { get; }

        public override int GetArea()
        {
            return (width * height);
        }
        public override int GetPerimeter()
        {
            return (width * 2 + height * 2);
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int width, int height, int center)
        {
            this.width = width;
            this.height = height;
            this.center = center;
        }
    }
    public class Square : Rectangle
    {
        private int side;
        public int Side { get; set; }

        public Square(int width, int height, int center)
            : base(width, height, center)
        {
            if (width != height)
            {
                throw new Exception("Width and height must be equal numbers");
            }
            else
            {
                this.side = width;
            }
        }

    }
}
