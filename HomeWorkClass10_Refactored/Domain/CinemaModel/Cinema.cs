using Domain.MovieModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.CinemaModel
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie>Movies { get; set; }

        public Cinema() { }
        public Cinema(string name) 
        {
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }


    }
}
