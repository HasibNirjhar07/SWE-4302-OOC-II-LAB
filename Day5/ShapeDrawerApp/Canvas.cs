using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawerApp
{
    public class Canvas
    {
      public Circle circle;
        public Square square;
        public Rectangle rectangle;

        public void AddShape(Shape shape)
        {
            if (shape is Circle)
            {
                circle = (Circle)shape; 
            }
            else if (shape is Square)
            {
                square = (Square)shape;
            }
            else if (shape is Rectangle)
            {
                rectangle = (Rectangle)shape;
            }
        }

   


    }
}
