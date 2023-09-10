using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapeDrawer
{
    public class Square:IShape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
        public double calculateArea()
        {
            return Side * Side;
        }

    }
}
