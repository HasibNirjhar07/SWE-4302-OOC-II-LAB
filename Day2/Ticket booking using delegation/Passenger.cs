using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_booking_using_delegation
{
    public class Passenger
    {
        public string Name { get; set; }
        public int Id { get; set; }


        public Passenger(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }


    }
}
