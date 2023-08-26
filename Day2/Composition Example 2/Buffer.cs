using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Example_2
{
    public class Buffer
    {

         private string content;

         public Buffer(string content)
         {
             this.content = content;
         }

         public string getContent()
         {
             return content;
         }
 }
}

