using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Vehicle
    {


        public string Name { get; set; }
        
        public Vehicle(string name) {
            Name=name;
       
        }
        public abstract void start();


        public abstract void stop();



        
    }
}
