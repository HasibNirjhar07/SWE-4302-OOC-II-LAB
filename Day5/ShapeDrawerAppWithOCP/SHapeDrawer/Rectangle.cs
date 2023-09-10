using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapeDrawer
{
    public class Rectangle:IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
        public double calculateArea()
        {
            return Length * Width;
        }
    }
}
