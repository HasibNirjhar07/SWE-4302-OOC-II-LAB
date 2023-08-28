using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new EpsonPrinter(PageType.A3);
            PrintController printController = new PrintController();

            string Content="I have a car";

            printController.Print("I have a car",printer);
            Printer printer1=new CannonPrinter(PageType.A4);
            printController.Print("I have a bike",printer1);
            Console.ReadLine();
        }
    }
}
