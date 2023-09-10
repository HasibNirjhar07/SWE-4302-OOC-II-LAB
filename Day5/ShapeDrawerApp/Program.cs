using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            canvas.AddShape(new Circle(10, 10, 10));
            canvas.AddShape(new Square(20, 20, 20));
            canvas.AddShape(new Rectangle(30, 30, 30, 30));
            Circle circle = canvas.circle;
            Square square = canvas.square;
            Rectangle rectangle = canvas.rectangle;
            circle.Draw();
            square.Draw();
            rectangle.Draw();
            Console.WriteLine("Circle area: {0}", circle.calculateArea());
            Console.WriteLine("Square area: {0}", square.calculateArea());
            Console.WriteLine("Rectangle area: {0}", rectangle.calculateArea());


       
            
            
            Console.ReadLine();
        }
    }
}
