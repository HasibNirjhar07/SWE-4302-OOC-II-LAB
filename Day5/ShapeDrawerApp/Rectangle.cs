using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawerApp
{
    public class Rectangle:Shape
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public Rectangle(int x, int y, int width, int length):base(x,y)
        {
            Width = width;
            Length = length;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle at ({0},{1}) with width {2} and length {3}", X, Y, Width, Length);
        }

        public override double calculateArea()
        {
            return Width * Length;
        }

    }
}
