using DogShelter.Domain.Core.Enteties;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogShelter.Domain.DB
{
   public static class DogShelterDB
    {

        public static List<Dog> ListOfDogs;

        static DogShelterDB()
        {
            ListOfDogs = new List<Dog>() { };
        }

        public static void PrintAll(List<Dog> ListOfDogs)
        {
            string list = "***List of dogs in the shelter***";
            Console.WriteLine($"\n\n{list,45}");
            foreach (var d in ListOfDogs)
            {
                Console.WriteLine($"\n\rDog ID : {d.Id}, Name: {d.Name}, Color: {d.Color}");
            }
        }



    }
}
