using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Application
{
    public class PrintController
    {
        public void Print(Printer printer)
        {
            printer.PrintColor();
            printer.Printside();
        }

    }
}
