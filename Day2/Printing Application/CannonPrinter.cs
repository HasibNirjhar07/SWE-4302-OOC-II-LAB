using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Application
{
    public class CannonPrinter:Printer,IPrinter
    {
        public PageType PageType { get; set; }
        public CannonPrinter(PageType type):base(type)
        {
            this.PageType = type;
        }
        public override void PrintColor()
        {
            Console.WriteLine($"Cannon Printer is printing in color on {PageType}");
        }
        public override void Printside()
        {
            Console.WriteLine("Cannon Printer is printing on both sides");
        }
    }
 
}
