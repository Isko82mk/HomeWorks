using System;
using System.Collections.Generic;
using DogShelter.Domain;
using DogShelter.Domain.Core.Enteties;
using DogShelter.Domain.DB;
using Services.Helpers;

namespace DogShelter
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog jony = new Dog() { Name = "Jony", Id = 2, Color = "black" };
            Dog mike = new Dog() { Name = "mike", Id = 5, Color = "white" };
            Dog persi = new Dog() { Name = "persi", Id = 12, Color = "brown" };
            Dog jecky = new Dog() { Name = "Jecky", Id = -2, Color = "black/white" };
            Dog suzi = new Dog() { Name = "S", Id = 15, Color = "red/white/brown" };

            Filtration.DogFiltration(jony);
            Filtration.DogFiltration(mike);
            Filtration.DogFiltration(persi);
            Filtration.DogFiltration(jecky);
            Filtration.DogFiltration(suzi);

            DogShelterDB.PrintAll(DogShelterDB.ListOfDogs);

            Console.ReadKey();
        }
    }
}
