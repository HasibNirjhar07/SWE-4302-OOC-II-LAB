using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_booking_using_delegation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger1 = new Passenger("John", 1);
            Passenger passenger2 = new Passenger("Mary", 2);
            Passenger passenger3 = new Passenger("Peter", 3);
            Passenger passenger4 = new Passenger("Paul", 4);
            Passenger passenger5 = new Passenger("Mark", 5);
            Passenger passenger6 = new Passenger("Luke", 6);
            Passenger passenger7 = new Passenger("James", 7);
            Passenger passenger8 = new Passenger("Jude", 8);
            Passenger passenger9 = new Passenger("Thomas", 9);
            Passenger passenger10 = new Passenger("Andrew", 10);
            Plane plane1 = new Plane(1, 2);
            Plane plane2 = new Plane(2, 2);
            Plane plane3 = new Plane(3, 2);
            Plane plane4 = new Plane(4, 2);
            Plane plane5 = new Plane(5, 2);
            Plane plane6 = new Plane(6, 2);
            Plane plane7 = new Plane(7, 2);
            Plane plane8 = new Plane(8, 2);
            Plane plane9 = new Plane(9, 2);
            Plane plane10 = new Plane(10, 2);
            Train train1 = new Train(1, 2);
            Booking_manager.bookTicket(plane1, passenger1);
            Booking_manager.bookTicket(plane1, passenger2);
            Booking_manager.bookTicket(plane1, passenger3);
            Booking_manager.bookTicket(plane1, passenger4);
            Booking_manager.bookTicket(plane1, passenger5);
            Booking_manager.bookTicket(plane1, passenger6);
            Booking_manager.bookTicket(plane1, passenger7);
            Booking_manager.bookTicket(plane1, passenger8);
            Booking_manager.bookTicket(plane1, passenger9);
            Booking_manager.bookTicket(plane1, passenger10);
            Booking_manager.bookTicket(plane2, passenger1);
            Booking_manager.bookTicket(plane2, passenger2);
            Booking_manager.bookTicket(plane2, passenger3);
            Booking_manager.bookTicket(plane2, passenger4);
            Booking_manager.bookTicket(plane2, passenger5);
            Booking_manager.bookTicket(plane2, passenger6);
            Booking_manager.bookTicket(plane2, passenger7);
            Booking_manager.bookTicket(plane2, passenger8);
            Booking_manager.bookTicket(plane2, passenger9);
            Booking_manager.bookTicket(plane2, passenger10);
            Booking_manager.bookTicket(plane3, passenger1);
            Booking_manager.bookTicket(train1, passenger2);
            
            
        }
    }
}
