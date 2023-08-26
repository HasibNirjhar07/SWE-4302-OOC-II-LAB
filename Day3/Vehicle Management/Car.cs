using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    public enum FuelType
    {
        DIESEL,
        PETROL,
        GASOLINE
    }
    public class Car:Vehicle,IDriveable
    {

        public FuelType fuelType;
       public Car (string name, FuelType fueltype):base(name)
        {
            this.fuelType = fueltype;
            
        }

        public override void start()
        {
            Console.WriteLine("Car started operating");
        }

        public override void stop() { Console.WriteLine("Car stopped"); }

        public void accelerate()
        {
            Console.WriteLine("Car started accelerating");

        }
    }
}
