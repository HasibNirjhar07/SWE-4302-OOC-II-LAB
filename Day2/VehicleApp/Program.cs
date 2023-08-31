using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trip trip = new Trip(VehicleType.SEDAN, 10, 30, 2);
            Console.WriteLine(trip.perHeadFare());
            Console.WriteLine(trip.canTakeTrip());
           

            Trip trip1= new Trip(VehicleType.MOTOR_BIKE, 10, 30, 2);
            Console.WriteLine(trip1.perHeadFare());
            Console.WriteLine(trip1.canTakeTrip());
           

            Trip trip2=new Trip(VehicleType.SEVEN_SEATER, 10, 30, 2);
            Console.WriteLine(trip2.perHeadFare());
            Console.WriteLine(trip2.canTakeTrip());
            Console.ReadKey();
        }
    }
}
