using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawerApp
{
    public class Circle:Shape
    {
        public int Radius { get; set; }
        public Circle(int x, int y, int radius):base(x,y)
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle at ({0},{1}) with radius {2}", X, Y, Radius);
        }
        public override double calculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
