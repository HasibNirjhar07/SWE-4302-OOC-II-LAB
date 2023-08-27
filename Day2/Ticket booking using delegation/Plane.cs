using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_booking_using_delegation
{
    public class Plane:Ticket
    {
        public int flightNumber { get; set; }
        public int availableSeats { get; set; }

        public Plane(int flightNumber, int availableSeats)
        {
            this.flightNumber = flightNumber;
            this.availableSeats = availableSeats;
        }

        public void bookTicket(Passenger passenger)
        {
            if (availableSeats > 0)
            {
                Console.WriteLine("Ticket booked for passenger " + passenger.Name + " with id " + passenger.Id + " in flight " + flightNumber);
                availableSeats--;
            }
            else
            {
                Console.WriteLine("No seats available in flight " + flightNumber);
            }
        }
    }
}
