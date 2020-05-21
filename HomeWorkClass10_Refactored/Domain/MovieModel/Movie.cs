using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.MovieModel
{
   public class Movie
    {
        public string Title { get; set; }
        public Genre Genre  { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie()
        {

        }
        public Movie(string title, Genre genre,int rating, double ticketPrice)
        {
            Title = title;
            Genre = genre;
            if (rating < 0 || rating > 5)
            {
                Console.WriteLine("You must enter number beatwin 1 and 5");
                throw new Exception("Wrong imput parameters");
            }
            Rating = rating;
            TicketPrice = ticketPrice*rating;
        }




    }
}
