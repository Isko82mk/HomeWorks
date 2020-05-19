using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

      public Movie()
        {

        }
      
        public Movie(string title, Genre genre, int rating, int ticketPrice)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = ticketPrice*5;
        }

     

    }
}
