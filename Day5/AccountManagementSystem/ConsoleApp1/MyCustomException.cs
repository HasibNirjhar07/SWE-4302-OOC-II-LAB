using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyCustomException:Exception
    {
        public MyCustomException(string message):base(message)
        {

        }


    }
}
