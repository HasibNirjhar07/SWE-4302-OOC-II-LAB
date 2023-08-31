using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ticket_booking_using_delegation;

namespace TestTicket
{
    [TestClass]
    public class BookTicketTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Plane plane = new Plane(1, 2);
            Passenger passenger = new Passenger("John", 1);
            Booking_manager.bookTicket(plane, passenger);

            //Act
            int expected = 1;

            int actual = plane.availableSeats;


            //Assert
            Assert.AreEqual(expected, actual);



        }
    }
}
