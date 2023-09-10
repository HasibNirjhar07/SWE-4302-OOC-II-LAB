using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawerApp
{
    public class Square:Shape
    {
        public int SideLength { get; set; }
        public Square(int x, int y, int sideLength):base(x,y)
        {
            SideLength = sideLength;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a square at ({0},{1}) with side length {2}", X, Y, SideLength);
        }
        public override double calculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
