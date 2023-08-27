using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Application
{
    public enum PageType
    {
        A3,
        A4,
        Letter
    }
    public abstract class Printer
    {
        public PageType Type { get; set; }

        public Printer(PageType type) {

            this.Type = type;
        
        }

        public abstract void PrintColor();

        public abstract void Printside();




    }
}
