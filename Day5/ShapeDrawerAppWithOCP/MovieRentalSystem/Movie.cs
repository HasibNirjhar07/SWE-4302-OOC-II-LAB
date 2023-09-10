using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int YearReleased { get; set; }
        public int Duration { get; set; }

        

        public Movie(string title, string genre, int yearReleased, int duration)
        {
            Title = title;
            Genre = genre;
            YearReleased = yearReleased;
            Duration = duration;
            
        }
    }
}
