using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Example_2
{
    public class File
    {
        private string fileName;
     public File(string fileName)
     {
        this.fileName = fileName;
     }

     public string getFileName()
     {
         return fileName;
      }
    }
}
