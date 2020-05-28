using Domain.CinemaModel;
using Domain.Enums;
using Domain.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class CinemaService
    {
        public void CinemaRepertuar()
        {
            Cinema cineplexx = new Cinema("Cineplex");
            Cinema milenium = new Cinema("Milenium");

            List<Movie> cineplexMovies = MovieService.CineplexxMovieList();
            List<Movie> mileniumMovies = MovieService.MileniumMovieList();

            cineplexx.Movies = cineplexMovies;
            milenium.Movies = mileniumMovies;


            List<Cinema> cinemas = new List<Cinema>();
            cinemas.Add(cineplexx);
            cinemas.Add(milenium);


            Console.WriteLine(" WELCOME TO THE MOVIE WORLD.\n" +
                "\n" +
                "Enter movie to see if it`s on cinemas repertuar;");

            string userImput = Console.ReadLine();

            GetCinemas(cinemas, userImput);
            
         
        }

        //cineplexCineam
        public void CinemaChuser(char[] arr)
        {
           

            if (arr[0] == '1' || arr[0] == 'c' || arr[0] == 'C')
            {

                Console.WriteLine("Do you like to see list of all movies or filtered by genre?\n" +
                    "\n" +
                    "Input 1 or 2 to select your preference\n" +
                    "" +
                    "1.All\n" +
                    "2.Genre");

                string userAll_Genre_Preference = Console.ReadLine();
                if (userAll_Genre_Preference == "1" || userAll_Genre_Preference == "All")
                {
                    List<Movie> cineplexmovies = MovieService.CineplexxMovieList();
                    PrintAllMovies(cineplexmovies);

                    //Get all Movies larger than "Rating" /// ***DONE***
                    //Get Movies below "TicketPrice" //Done
                    //Get Movies above "TicketPrice"//Done

                    Console.WriteLine("\n" +
                        "\n" +
                        "Woud you like to filter movies by 'larger than rating'? Y/N");

                    string userRatingFilterImput = Console.ReadLine();
                    MovieService service = new MovieService();
                    service.LargerThenRating(userRatingFilterImput, cineplexmovies);

                    Console.WriteLine("Woud you like to filter movies by Price?Y/N");
                    string userImput = Console.ReadLine();
                    service.TiketPrice(userImput, cineplexmovies);

                    Console.WriteLine("\n" +
                        "Which move do you like to watch");

                    string userMoveSelect = Console.ReadLine();

                    Movie movie = cineplexmovies.SingleOrDefault(m => m.Title.ToLower() == userMoveSelect);
                    MovieSelectorLogic(userMoveSelect, movie);
                }
                else
                {
                    List<Movie> cineplexmovies = MovieService.CineplexxMovieList();
                    PrintMoviesByGenre(cineplexmovies);

                    Console.WriteLine("\n" +
                        "Select favorite genre from the list ");
                    string userGenreSelect = Console.ReadLine();

                    Genre genre = new Genre();
                    GenerSelectLogic(userGenreSelect, ref genre);


                    List<Movie> filtratedByGener = FilteredMoviesByGender(cineplexmovies, genre);
                    PrintMoviesByGenre(filtratedByGener);

                    Console.WriteLine("\n" +
                        "Select one of the movie on the list.");
                    string userSelctMovieByGener = Console.ReadLine();

                    Movie userSelectedByGenerMovie = filtratedByGener.SingleOrDefault(m => m.Title.ToLower() == userSelctMovieByGener.ToLower());
                    MovieSelectorLogic(userSelctMovieByGener, userSelectedByGenerMovie);
                }
            }
            ///MileniumCinema
            else if (arr[0] == '2' || arr[0] == 'm' || arr[0] == 'M')
            {

                //Console.WriteLine(" You are in the Millenium Cinema.\n" +
                //    " We are colosed until further notice.\n" +
                //    " thank you for your understanding in advance.\n" +
                //    " Buy :) ");


                Console.WriteLine("Do you like to see list of all movies or filtered by genre?\n" +
                 "\n" +
                 "Input 1 or 2 to select your preference\n" +
                 "" +
                 "1.All\n" +
                 "2.Genre");

                string userAll_Genre_Preference = Console.ReadLine();

                if (userAll_Genre_Preference == "1" || userAll_Genre_Preference == "All")
                {
                    List<Movie> milenium = MovieService.MileniumMovieList();
                    PrintAllMovies(milenium);

                    Console.WriteLine("\n" +
                   "\n" +
                   "Woud you like to filter movies by 'larger than rating'? Y/N");

                    string userRatingFilterImput = Console.ReadLine();
                    MovieService service = new MovieService();
                    service.LargerThenRating(userRatingFilterImput, milenium);

                    Console.WriteLine("Woud you like to filter movies by Price?Y/N");
                    string userImput = Console.ReadLine();
                    service.TiketPrice(userImput, milenium);



                    Console.WriteLine("\n" +
                        "Which move do you like to watch");

                    string userMoveSelect = Console.ReadLine();
                    Movie movie = milenium.SingleOrDefault(m => m.Title.ToLower() == userMoveSelect);
                    MovieSelectorLogic(userMoveSelect, movie);

                }
                else
                {
                    List<Movie> milenium = MovieService.MileniumMovieList();
                    PrintMoviesByGenre(milenium);

                    Console.WriteLine("\n" +
                    "Select favorite genre from the list ");
                    string userGenreSelect = Console.ReadLine();

                    Genre genre = new Genre();
                    GenerSelectLogic(userGenreSelect, ref genre);

                    List<Movie> filtratedByGener = FilteredMoviesByGender(milenium, genre);
                    PrintMoviesByGenre(filtratedByGener);

                    Console.WriteLine("\n" +
                     "Select one of the movie on the list.");
                    string userSelctMovieByGener = Console.ReadLine();


                    Movie userSelectedByGenerMovie = filtratedByGener.SingleOrDefault(m => m.Title.ToLower() == userSelctMovieByGener.ToLower());
                    MovieSelectorLogic(userSelctMovieByGener, userSelectedByGenerMovie);

                }

            }
           
        }
        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching movie {movie.Title}");
        }
        public static void PrintAllMovies(List<Movie> movies)
        {
            movies.ForEach(movie => Console.WriteLine(movie.Title));
        }

        public static void PrintMoviesByGenre(List<Movie> movies)
        {
            movies.ForEach(movie => Console.WriteLine($"{movie.Genre,25} {movie.Title,25}"));
        }

        public static void MovieSelectorLogic(string input, Movie movie)
        {
            CinemaService mPlaying = new CinemaService();
            if (movie == null)
            {
                Console.WriteLine(" Error...Wrong movie selected.Enter movie name whith white spaces including.");
                //throw new Exception("Error...wrong move selection!");
            }
            else { mPlaying.MoviePlaying(movie); }
        }

        public static List<Movie> FilteredMoviesByGender(List<Movie> movies, Genre genre)
        {

            return movies.Where(m => m.Genre == genre).ToList();

        }

        public static void GenerSelectLogic(string input, ref Genre genre)
        {

            switch (input.ToLower())
            {
                case "comedy":
                    genre = Genre.Comedy;
                    break;
                case "horror":
                    genre = Genre.Horror;
                    break;
                case "action":
                    genre = Genre.Action;
                    break;
                case "drama":
                    genre = Genre.Drama;
                    break;
                case "sci-fi":
                    genre = Genre.SciFi;
                    break;
            }
        }

        /// Get all Cinemas that hava a "Movie" on their list

        public void GetCinemas(List<Cinema> cinemas, string input)
        {
            foreach (Cinema c in cinemas)
            {
                foreach (Movie m in c.Movies)
                {
                    if (m.Title.ToLower() == input.ToLower())
                    {
                        Console.WriteLine($"{c.Name} {m.Title} {m.TicketPrice} $");
                    }
                }
            }
        }
        /// Get all Cinemas that hava a "Movie" on their list >> METHOD


        //STAGE 1

        //public void GetCinemas1(List<Cinema> cinemas, string input)
        //{
        //    foreach (Cinema c in cinemas)
        //    {
        //        foreach (Movie m in c.Movies)
        //        {
        //            if (m.Title.ToLower() == input.ToLower())
        //            {
        //                Console.WriteLine($"{c.Name} {m.Title} {m.TicketPrice} $");
        //            }
        //        }
        //    }
        //}

        /// STAGE 2 


        // public void GetCinemas(List<Cinema> cinemas, string input)
        //{

        //        stage 2 
        //   foreach (Cinema c in cinemas) 
        //     {
        //    c.Movies.Where(m => m.Title == input).ToList();
        //      }

        //         STAGE 3  kompletno vo linija

        //    cinemas.ForEach(c => c.Movies.Where(m => m.Title == input).ToList());

        // }








    }
}
