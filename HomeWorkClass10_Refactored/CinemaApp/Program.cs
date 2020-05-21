using System;
using Domain.Enums;
using Domain.MovieModel;
using Services;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CinemaService cinemaChuserService = new CinemaService();
            Console.WriteLine("Welcome to the movie World.\n" +
                "Pls. select prefered cinema by entering 1 or 2:\n" +
                "1.Cineplexx\n" +
                "2.Millenium ");

            string userCinemaSelect =  Console.ReadLine();
            char[] cinemaChars = userCinemaSelect.ToCharArray();
             cinemaChuserService.CinemaChuser(cinemaChars);
             Console.ReadLine();
        }

    }
}
