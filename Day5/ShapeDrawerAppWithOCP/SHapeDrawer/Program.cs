using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapeDrawer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            canvas.AddShape(new Circle(5));
            canvas.AddShape(new Square(5));
            canvas.DrawShapes();
            

            Circle circle = new Circle(5);
            Square square=new Square(5);
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("Circle Area: "+circle.calculateArea());
            Console.WriteLine("Square Area: "+square.calculateArea());
            Console.WriteLine("Rectangle Area: "+rectangle.calculateArea());
            Console.ReadLine();
        }
    }
}
