using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bicycle:Vehicle,IRideable
    {



        public Bicycle(string name) : base(name)
        {
            
        }

        public void ride()
        {
            Console.WriteLine("Riding the bicycle");
        }

        public override void start()
        {
            Console.WriteLine("Starting the bicycle");
        }

        public override void stop()
        {
            Console.WriteLine("Stopping the bicycle");
        }

    }
}
