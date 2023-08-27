using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_booking_using_delegation
{
    public interface Ticket
    {
        void bookTicket(Passenger passenger);
    }
}
