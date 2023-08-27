using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_booking_using_delegation
{
    public class Booking_manager
    {
        public static void bookTicket(Ticket ticket, Passenger passenger)
        {
            ticket.bookTicket(passenger);
        }


    }
}
