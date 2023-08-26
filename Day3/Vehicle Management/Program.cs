using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
           Vehicle Car = new Car("Balaka",FuelType.DIESEL);

            Vehicle Bicycle= new Bicycle("Bicycle");

            VehicleManager.startVehicle(Car);
            VehicleManager.stopVehicle(Car);
            VehicleManager.accelerateVehicle((IDriveable)Car);
            VehicleManager.startVehicle(Bicycle);
            VehicleManager.stopVehicle(Bicycle);
            VehicleManager.rideVehicle((IRideable)Bicycle);



        }
    }
}
