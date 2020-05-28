using System;
using Domain.Enums;
using Domain.MovieModel;
using Services;
using Domain.CinemaModel;
using System.Collections.Generic;
using System.Net;
using System.Linq;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CinemaService service = new CinemaService();
            service.CinemaRepertuar();

            Console.WriteLine("\n" +
            "Pls. select prefered cinema by entering 1 or 2:\n" +
            "1.Cineplexx\n" +
            "2.Millenium ");

            string userCinemaSelect = Console.ReadLine();
            char[] cinemaChars = userCinemaSelect.ToCharArray();
            service.CinemaChuser(cinemaChars);
            Console.ReadKey();
        }
    }
}
