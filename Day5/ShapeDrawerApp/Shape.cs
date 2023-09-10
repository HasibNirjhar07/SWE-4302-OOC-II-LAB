using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawerApp
{
    public abstract class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Draw();
        public abstract double calculateArea();
    }
}
