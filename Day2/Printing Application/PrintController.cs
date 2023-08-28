using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Application
{
    public class PrintController
    {
        public string Content { get; set; }
  
        
        
        public void Print(string Content,Printer printer)
        {
            printer.PrintColor(Content);
            printer.Printside(Content);
        }

    }
}
