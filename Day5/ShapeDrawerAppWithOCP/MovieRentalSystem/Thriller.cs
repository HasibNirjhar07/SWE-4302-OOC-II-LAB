using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem
{
    public class Thriller
    {
        public double price { get; set; }
        public Thriller(string title, string genre, int yearReleased, int duration, double price) : base(title, genre, yearReleased, duration)
        {
            this.price = price;
        }
        public double getDiscount()
        {
            return (price - price*0.3);
        }
    }
}
