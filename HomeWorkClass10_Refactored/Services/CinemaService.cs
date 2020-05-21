using Domain.CinemaModel;
using Domain.Enums;
using Domain.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Services
{
    public class CinemaService
    {
        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching movie {movie.Title}");
        }


        public void CinemaChuser(char[] arr)
        {

            if (arr[0] == '1' || arr[0] == 'c' || arr[0] == 'C')
            {
                //Console.WriteLine(" I am in the Cineplex ");
                //1.cineplex /// 2.milenium

                Console.WriteLine("Do you like to see list of all movies or filtered by genre?\n" +
                    "\n" +
                    "Input 1 or 2 to select your preference\n" +
                    "" +
                    "1.All\n" +
                    "2.Genre");
                 
                string userAll_Genre_Preference = Console.ReadLine();
                if (userAll_Genre_Preference == "1" || userAll_Genre_Preference=="All")
                {
                    List<Movie> cineplexmovies = MovieService.CineplexxMovieList();
                    PrintAllMovies(cineplexmovies);

                    Console.WriteLine("Which move do you like to watch");

                    string userMoveSelect= Console.ReadLine();
                    Movie movie = cineplexmovies.SingleOrDefault(m=>m.Title.ToLower() == userMoveSelect);
                    MovieSelectorLogic(userMoveSelect, movie);
                }
                else
                {
                    List<Movie> mileniumMovies = MovieService.MileniumMovieList();
                    PrintMoviesByGenre(mileniumMovies);

                    Console.WriteLine("\n" +
                        "Select favorite genre from the list ");
                    string userGenreSelect = Console.ReadLine();

                     Genre genre = new Genre();
                     GenerSelectLogic(userGenreSelect,ref genre);

                    List<Movie> cineplexMovies = MovieService.CineplexxMovieList();
                    List<Movie> filtratedByGener = FilteredMoviesByGender(cineplexMovies, genre);
                    PrintMoviesByGenre(filtratedByGener);

                    Console.WriteLine("\n" +
                        "Select one of the movie on the list.");
                    string userSelctMovieByGener = Console.ReadLine();
                    
                    Movie userSelectedByGenerMovie = filtratedByGener.SingleOrDefault(m=>m.Title.ToLower() == userSelctMovieByGener.ToLower());
                    MovieSelectorLogic(userSelctMovieByGener, userSelectedByGenerMovie);
                }
            }
            else if (arr[0] == '2' || arr[0] == 'm' || arr[0] == 'M')
            {

                Console.WriteLine(" You are in the Millenium Cinema.\n" +
                    " We are colosed until further notice.\n" +
                    " thank you for your understanding in advance.\n" +
                    " Buy :) ");
            }

        }

        public static void PrintAllMovies(List<Movie> movies)
        {
            movies.ForEach(movie=>Console.WriteLine(movie.Title));
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
                throw new Exception("Error...wrong move selection!");
            }
            else { mPlaying.MoviePlaying(movie); }
        }

        public static List<Movie> FilteredMoviesByGender(List<Movie> movies, Genre genre )
        {

            return movies.Where(m => m.Genre == genre).ToList();

        }

        public static void GenerSelectLogic(string input, ref Genre genre )
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

    }
}
