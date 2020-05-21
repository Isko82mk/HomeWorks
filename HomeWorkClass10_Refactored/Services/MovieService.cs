using Domain.Enums;
using Domain.MovieModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
  public class MovieService
    {
         
       public static List<Movie> CineplexxMovieList()
        {
            Movie dieHard = new Movie("Die Hard", Genre.Action, 5, 250);
            Movie tangoAndCash = new Movie("Tango and Cash", Genre.Action, 4, 200);
            Movie savingPrivateRyan = new Movie("Saving Private Ryan ", Genre.Drama, 5, 300);
            Movie theGreenMile = new Movie("The Green Mile", Genre.Drama, 5, 250);
            Movie matrix = new Movie("Matrix", Genre.SciFi, 5, 400);
            Movie interstellar = new Movie("Interstellar", Genre.SciFi, 4, 300);
            Movie dumbAndDumber = new Movie("Dumb and Dumber", Genre.Comedy, 5, 500);
            Movie aceVentura = new Movie("Ace Ventura", Genre.Comedy, 5, 400);
            Movie aNightmareOnElmStreet = new Movie("A Nightmare on Elm Street", Genre.Horror, 5, 200);
            Movie theConjuring = new Movie("The Conjuring", Genre.Horror, 3, 200);

            return new List<Movie>(){ dieHard, tangoAndCash, savingPrivateRyan, theGreenMile, matrix, interstellar, dumbAndDumber, aceVentura, aNightmareOnElmStreet, theConjuring };
        }

        public static List<Movie> MileniumMovieList()
        {
            Movie theEqualizer = new Movie("The Equalizer", Genre.Action, 5, 250);
            Movie madMaxFuryRoad = new Movie("Mad Max: Fury Road", Genre.Action, 2, 200);
            Movie theGodfather = new Movie("The Godfather ", Genre.Drama, 5, 300);
            Movie léonTheProfessional = new Movie("Léon: The Professional", Genre.Drama, 5, 250);
            Movie alien = new Movie("Alien", Genre.SciFi, 5, 400);
            Movie theTerminator = new Movie("TheTerminator", Genre.SciFi, 5, 300);
            Movie oldSchool = new Movie("Old School", Genre.Comedy, 5, 500);
            Movie borat = new Movie("Borat", Genre.Comedy, 5, 400);
            Movie theMist = new Movie("The Mist", Genre.Horror, 5, 200);
            Movie paranormalActivity = new Movie("Paranormal Activity", Genre.Horror, 3, 200);

            return new List<Movie>() { theEqualizer, madMaxFuryRoad, theGodfather, léonTheProfessional, alien, theTerminator, oldSchool, borat, theMist, paranormalActivity };
        }

    }
}
