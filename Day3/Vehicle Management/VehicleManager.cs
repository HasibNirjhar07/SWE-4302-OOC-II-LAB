using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class VehicleManager
    {
        public static void startVehicle(Vehicle vehicle)
        {
            vehicle.start();

        }

        public static void stopVehicle(Vehicle vehicle)
        {
            vehicle.stop();
        }

        public static void accelerateVehicle(IDriveable vehicle)
        {
            vehicle.accelerate();
        }

        public static void rideVehicle(IRideable vehicle)
        {
            vehicle.ride();
        }
    }
}
