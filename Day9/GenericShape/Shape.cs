using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericShape
{
    abstract class Shape
    {
        public abstract void Draw();

    }

    abstract class _2DShape:Shape{

     }

    abstract class _3DShape : Shape { }

     class Circle : _2DShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing 2D Circle");

        }

       
    }

    class Rectangle : _2DShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing 2D Rectangle");
        }
    }

    class Triangle : _2DShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing 2D triangle");
        }
    }

    class Cube:_3DShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing 3D cube");
        }
    }

    class Cylinder : _3DShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing 3D cylinder");
        }
    }

}
