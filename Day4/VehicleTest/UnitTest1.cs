using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace VehicleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sedan_Can_Take_Trip()
        {
          Trip trip = new Trip(VehicleType.SEDAN, 10, 30, 2);
                Assert.IsTrue(trip.canTakeTrip());
        }

        [TestMethod]
        public void SevenSeaterCar_can_take_Trip()
        {
            Trip trip = new Trip(VehicleType.SEVEN_SEATER, 10, 30, 2);
            Assert.IsTrue(trip.canTakeTrip());
        }
        [TestMethod]

        public void MotorBike_Can_Take_Trip()
        {
            Trip trip = new Trip(VehicleType.MOTOR_BIKE, 10, 30, 1);
            Assert.IsTrue(trip.canTakeTrip());
        }

        [TestMethod]

        public void Sedan_Per_Head_Fare()
        {
            Trip trip = new Trip(VehicleType.SEDAN, 10, 30, 2);
            Assert.AreEqual(205, trip.perHeadFare());
        }

        [TestMethod]

        public void SevenSeater_Per_Head_Fare()
        {
            Trip trip = new Trip(VehicleType.SEVEN_SEATER, 10, 30, 2);
            Assert.AreEqual(150, trip.perHeadFare());
        }

        [TestMethod]

        public void MotorBike_Per_Head_Fare()
        {
            Trip trip = new Trip(VehicleType.MOTOR_BIKE, 10, 30, 2);
            Assert.AreEqual(100, trip.perHeadFare());
        }
    }
}
