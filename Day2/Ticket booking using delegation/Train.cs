using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_booking_using_delegation
{
    public class Train : Ticket
    {
        private int TrainNo { get; set; }
        
        private int AvailableSeats { get; set; }

        public Train(int trainNo, int availableSeats)
        {
            TrainNo = trainNo;
            AvailableSeats = availableSeats;
        }

        public void bookTicket(Passenger passenger)
        {
            if (AvailableSeats > 0)
            {
                Console.WriteLine("Ticket booked for passenger {0} on train {1}", passenger.Name, TrainNo);
                AvailableSeats--;
            }
            else
            {
                Console.WriteLine("No seats available for train {0}", TrainNo);
            }
        }
    
    
    }

   
}
