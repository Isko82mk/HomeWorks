using System;
using Services;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkClass10_Task_1
{
    class Program
    {
        static void Main(string[] args)
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

           List<Movie> mileniumMovies = new List<Movie>();
           mileniumMovies.Add(dieHard);
           mileniumMovies.Add(tangoAndCash);
           mileniumMovies.Add(savingPrivateRyan);
           mileniumMovies.Add(theGreenMile);
           mileniumMovies.Add(matrix);
           mileniumMovies.Add(interstellar);
           mileniumMovies.Add(dumbAndDumber);
           mileniumMovies.Add(aceVentura);
           mileniumMovies.Add(aNightmareOnElmStreet);
           mileniumMovies.Add(theConjuring);

            List<Movie> cineplexMovies = new List<Movie>();
            cineplexMovies.Add(theEqualizer);
            cineplexMovies.Add(madMaxFuryRoad);
            cineplexMovies.Add(theGodfather);
            cineplexMovies.Add(léonTheProfessional);
            cineplexMovies.Add(alien);
            cineplexMovies.Add(theTerminator);
            cineplexMovies.Add(oldSchool);
            cineplexMovies.Add(borat);
            cineplexMovies.Add(theMist);
            cineplexMovies.Add(paranormalActivity);

            Cinema milenium = new Cinema("Milenium",1, mileniumMovies);
            Cinema cineplex = new Cinema("Cineplex", 6, cineplexMovies);

            Cinema cinemaCervice = new Cinema();

            //moviePlaying.MoviePlaying(dieHard);
            //PrintMovies(mileniumMovies);
            //PrintMovies(cineplexMovies);


            Console.WriteLine("Please chuse cinema:\n" +
                "1.Milenium\n" +
                "2.Cineplex\n" +
                "Select 1 or 2");
            int userCinemaChose = int.Parse(Console.ReadLine());

            if (userCinemaChose== 1)
            {
                Console.WriteLine("Do you like to see all mouvies or by gender\n" +
                    "1.All movies\n" +
                    "2.By gender\n" +
                    "\n" +
                    "Chose 1 or 2");
                int genderAllChoice = int.Parse(Console.ReadLine());

                if (genderAllChoice == 1)
                {
                    PrintMovies(mileniumMovies);
                    Console.WriteLine("\n" +
                      "Chose a movie from the list  you like to watch");
                    string userMovieSelect = Console.ReadLine().ToLower();
                        
                    if(userMovieSelect=="die hard")
                    {
                        cinemaCervice.MoviePlaying(dieHard);
                    }
                    else if (userMovieSelect == "tango and cash") 
                    {
                        cinemaCervice.MoviePlaying(tangoAndCash);
                    }
                    else if (userMovieSelect == "saving private ryan")
                    {
                        cinemaCervice.MoviePlaying(savingPrivateRyan);
                    }
                    else if (userMovieSelect == "the green mile")
                    {
                        cinemaCervice.MoviePlaying(theGreenMile);
                    }
                    else if (userMovieSelect == "matrix")
                    {
                        cinemaCervice.MoviePlaying(matrix);
                    }
                    else if (userMovieSelect == "interstellar")
                    {
                        cinemaCervice.MoviePlaying(interstellar);
                    }
                    else if (userMovieSelect == "dumb and dumber")
                    {
                        cinemaCervice.MoviePlaying(dumbAndDumber);
                    }
                    else if (userMovieSelect == "ace ventura")
                    {
                        cinemaCervice.MoviePlaying(aceVentura);
                    }
                    else if (userMovieSelect == "a nightmare on elm street")
                    {
                        cinemaCervice.MoviePlaying(aNightmareOnElmStreet);
                    }
                    else if (userMovieSelect == "the conjuring")
                    {
                        cinemaCervice.MoviePlaying(theConjuring);
                    }
                }
                else if(genderAllChoice == 2)
                {
                    Console.WriteLine("Chose a genre from the list :\n" +
                        "\n" +
                        "1.Comedy\n" +
                        "2.Horror\n" +
                        "3.Action\n" +
                        "4.Drama\n" +
                        "5.Sci-Fi\n" +
                        "\n" +
                        "Select number from 1 to 5");
                    int userGenreSelect = int.Parse(Console.ReadLine());
                    if (userGenreSelect == 1)
                    {
                        List<Movie> gener = mileniumMovies.Where(m => m.Genre == Genre.Comedy).ToList();
                        PrintColection(gener);
                        Console.WriteLine("\n" +
                            "Chose the movie you like to wach\n");
                        int userComedySelect = int.Parse(Console.ReadLine());
                        if (userComedySelect == 1)
                        {
                            cinemaCervice.MoviePlaying(dumbAndDumber);
                        }
                        else
                        {
                            cinemaCervice.MoviePlaying(aceVentura);
                        }
                            
                    }
                    else if (userGenreSelect == 2)
                    {

                        List<Movie> gener = mileniumMovies.Where(m => m.Genre == Genre.Horror).ToList();
                        PrintColection(gener);
                        Console.WriteLine("\n" +
                            "Chose the movie you like to wach\n");
                        int userComedySelect = int.Parse(Console.ReadLine());
                        if (userComedySelect == 1)
                        {
                            cinemaCervice.MoviePlaying(aNightmareOnElmStreet);
                        }
                        else
                        {
                            cinemaCervice.MoviePlaying(theConjuring);
                        }
                    }
                    else if (userGenreSelect == 3)
                    {

                        List<Movie> gener = mileniumMovies.Where(m => m.Genre == Genre.Action).ToList();
                        PrintColection(gener);
                        Console.WriteLine("\n" +
                            "Chose the movie you like to wach\n");
                        int userComedySelect = int.Parse(Console.ReadLine());
                        if (userComedySelect == 1)
                        {
                            cinemaCervice.MoviePlaying(dieHard);
                        }
                        else
                        {
                            cinemaCervice.MoviePlaying(tangoAndCash);
                        }
                    }
                    else if (userGenreSelect == 4)
                    {

                        List<Movie> gener = mileniumMovies.Where(m => m.Genre == Genre.Drama).ToList();
                        PrintColection(gener);
                        Console.WriteLine("\n" +
                            "Chose the movie you like to wach\n");
                        int userComedySelect = int.Parse(Console.ReadLine());
                        if (userComedySelect == 1)
                        {
                            cinemaCervice.MoviePlaying(savingPrivateRyan);
                        }
                        else
                        {
                            cinemaCervice.MoviePlaying(theGreenMile);
                        }
                    }
                    else if (userGenreSelect == 5)
                    {

                        List<Movie> gener = mileniumMovies.Where(m => m.Genre == Genre.SciFi).ToList();
                        PrintColection(gener);
                        Console.WriteLine("\n" +
                            "Chose the movie you like to wach\n");
                        int userComedySelect = int.Parse(Console.ReadLine());
                        if (userComedySelect == 1)
                        {
                            cinemaCervice.MoviePlaying(matrix);
                        }
                        else
                        {
                            cinemaCervice.MoviePlaying(interstellar);
                        }
                    }



                }

            }else if (userCinemaChose ==2) 
            { 

            }
              



            Console.ReadLine();                 

        }

        public static void PrintMovies(List<Movie> movies)
        {
            foreach(Movie movie in movies)
            {
                Console.WriteLine($"{movie.Title,25}");
            }
        }

        public static void PrintColection(List<Movie> colection)
        {

            foreach (var item in colection)
            {
                Console.WriteLine($"{item.Title} {item.Genre}");
            }

        }


    }
}
