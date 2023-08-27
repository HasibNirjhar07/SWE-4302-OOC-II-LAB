using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Application
{
   
    public class EpsonPrinter:Printer,IPrinter
    {
        public PageType PageType { get; set; }

        public EpsonPrinter(PageType pagetype):base(pagetype) {
        this.PageType = pagetype;
        
        }
        public override void PrintColor()
        {
            Console.WriteLine($"Epson printer prints in black and white on {PageType}");

        }

        public override void Printside()
        {
            Console.WriteLine("Epson printer prints on both sides");
        }



    }
}
