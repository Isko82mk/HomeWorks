using Domain.Enums;
using Domain.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class MovieService
    {

        public static List<Movie> CineplexxMovieList()
        {
            Movie dieHard = new Movie("Die Hard", Genre.Action, 5, 50);
            Movie tangoAndCash = new Movie("Tango and Cash", Genre.Action, 4, 20);
            Movie savingPrivateRyan = new Movie("Saving Private Ryan ", Genre.Drama, 3, 40);
            Movie theGreenMile = new Movie("The Green Mile", Genre.Drama, 1, 25);
            Movie matrix = new Movie("Matrix", Genre.SciFi, 2, 40);
            Movie interstellar = new Movie("Interstellar", Genre.SciFi, 4, 30);
            Movie dumbAndDumber = new Movie("Dumb and Dumber", Genre.Comedy, 5, 50);
            Movie aceVentura = new Movie("Ace Ventura", Genre.Comedy, 3, 40);
            Movie aNightmareOnElmStreet = new Movie("A Nightmare on Elm Street", Genre.Horror, 2, 20);
            Movie theConjuring = new Movie("The Conjuring", Genre.Horror, 3, 20);
            Movie theEqualizer = new Movie("The Equalizer", Genre.Action, 1, 30);
            Movie alien = new Movie("Alien", Genre.SciFi, 5, 40);
            Movie theTerminator = new Movie("TheTerminator", Genre.SciFi, 2, 40);

            return new List<Movie>() { theTerminator, alien, theEqualizer, dieHard, tangoAndCash, savingPrivateRyan, theGreenMile, matrix, interstellar, dumbAndDumber, aceVentura, aNightmareOnElmStreet, theConjuring };
        }

        public static List<Movie> MileniumMovieList()
        {
            Movie theEqualizer = new Movie("The Equalizer", Genre.Action, 1, 25);
            Movie madMaxFuryRoad = new Movie("Mad Max: Fury Road", Genre.Action, 2, 20);
            Movie theGodfather = new Movie("The Godfather ", Genre.Drama, 4, 300);
            Movie léonTheProfessional = new Movie("Léon: The Professional", Genre.Drama, 5, 25);
            Movie alien = new Movie("Alien", Genre.SciFi, 5, 20);
            Movie theTerminator = new Movie("TheTerminator", Genre.SciFi, 2, 30);
            Movie oldSchool = new Movie("Old School", Genre.Comedy, 3, 50);
            Movie borat = new Movie("Borat", Genre.Comedy, 1, 40);
            Movie theMist = new Movie("The Mist", Genre.Horror, 4, 20);
            Movie paranormalActivity = new Movie("Paranormal Activity", Genre.Horror, 3, 20);
            Movie matrix = new Movie("Matrix", Genre.SciFi, 2, 60);
            Movie theConjuring = new Movie("The Conjuring", Genre.Horror, 4, 20);
            Movie dumbAndDumber = new Movie("Dumb and Dumber", Genre.Comedy, 4, 50);

            return new List<Movie>() { dumbAndDumber, theConjuring, matrix, theEqualizer, madMaxFuryRoad, theGodfather, léonTheProfessional, alien, theTerminator, oldSchool, borat, theMist, paranormalActivity };
        }

        public void LargerThenRating(string userInput, List<Movie> movieList)
        {
            if (userInput == "y" || userInput == "Y")
            {
                Console.WriteLine(" Filter 'Larger then' from 1 to 4");
                int userRatingInput = int.Parse(Console.ReadLine());

                List<Movie> largerThenRating = movieList.Where(m => m.Rating > userRatingInput)
                                                        .OrderBy(m => m.Rating)
                                                        .ToList();

                largerThenRating.ForEach(var => Console.WriteLine($"{var.Rating,15} {var.Title,15}"));
            }
        }

        public void TiketPrice(string userImput, List<Movie> movies)
        {
            try
            {

                if (userImput == "y" || userImput == "Y")
                {

                    Console.WriteLine("Get movies\n" +
                        "\n" +
                        "1.Below Ticket Price\n" +
                        "2.Above Ticket Price\n" +
                        "\n" +
                        "Select by entering 1 or 2");
                    string optionSelect = Console.ReadLine();

                    if (optionSelect == "1")
                    {
                        Console.WriteLine("Enter below price");
                        double userBelowPriceImput = double.Parse(Console.ReadLine());

                        List<Movie> belowPriceFilter = movies.Where(m => m.TicketPrice < userBelowPriceImput).ToList();//Kako da iskombiniram lambda so ternary operator???

                        belowPriceFilter.ForEach(var => Console.WriteLine($"{var.TicketPrice,15} {var.Title,15}"));

                    }
                    else if (optionSelect == "2")
                    {

                        Console.WriteLine("Enter Aobove price");
                        double userBelowPriceImput = double.Parse(Console.ReadLine());

                        List<Movie> belowPriceFilter = movies.Where(m => m.TicketPrice > userBelowPriceImput).ToList();
                        belowPriceFilter.ForEach(var => Console.WriteLine($"{var.TicketPrice,15} {var.Title,15}"));

                    }
                }
                else
                {
                    Console.WriteLine("ok..proceed with the next options");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid input");
            }


        }

















    }
}
