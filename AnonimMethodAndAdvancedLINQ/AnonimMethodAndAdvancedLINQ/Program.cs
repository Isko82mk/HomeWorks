using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonimMethodAndAdvancedLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.All pesonsFirstName starting with "R",ordered by age-des.
            List<Person> allPersonsNames = DogOwners.people.Where(x => x.Name.Substring(0, 1) == "R")
                                                            .OrderBy(x => x.Name)
                                                            .ToList();


            Console.WriteLine(" \n All names starting with  'R' desending Order\n");
            if (allPersonsNames.Count == 0)
            {
                Console.WriteLine("Empty list");
            }
            else
            {
                allPersonsNames.ForEach(var => Console.WriteLine(var.Name));
            };

            //2.Find All brown dogs names and ages odler then 3, orderder by age assend.order

            List<Dog> allBrownDogs = DogOwners.dogs.Where(x => x.Age > 3)
                                                   .OrderBy(x => x.Age)
                                                   .ToList();

            Console.WriteLine("\n  All brown dogs older than 3 years :");
            allBrownDogs.ForEach(var => Console.WriteLine($"        {var.Name} {var.Age}"));

            //3.Find and print all persons with more then 2 dogs, ordered by name descend.order

            List<Person> moreThenTwoDogPerson = DogOwners.people.Where(x => x.dogs.Count > 2)
                                                                .OrderByDescending(x => x.Name)
                                                                .ToList();

            Console.WriteLine(" \n Owners with more then 2 dogs are: ");
            moreThenTwoDogPerson.ForEach(var => Console.WriteLine($"  {var.Name} { var.LastName}"));

            //4.Find and pring all Freddy`s dog`s older > 1year;
            List<Dog> dogsOfFreddy = DogOwners.people.Where(x => x.Name == "Freddy")
                                        .SelectMany(x => x.dogs)
                                        .OrderByDescending(x => x.Name)
                                        .ToList();


            Console.WriteLine(" \n Freddys dogs are:\n");
            dogsOfFreddy.ForEach(var => Console.WriteLine($" Name: {var.Name,2}, Color:{var.Color,2}, Age:{var.Age,2}\n"));

            //5.Find and print Nathen`s first dog

            List<Dog> natansFirst = DogOwners.people
                                            .Where(x => x.Name == "Nathen")
                                            .Select(x => x.dogs[0]).ToList();

            Console.WriteLine(" Nathnas first dog`s name is :");
            natansFirst.ForEach(var => Console.WriteLine($"   {var.Name}"));

            //6.Find and print all white dogs names from Cristofer,Freddy,Erin,and Amelia ordered by name -assending

            List<Dog> whiteDogsNames = DogOwners.dogs.Where(x => x.Color == "White")
                                                      .OrderBy(x => x.Name)
                                                      .ToList();

            Console.WriteLine("\n All  white dogs: ");
            whiteDogsNames.ForEach(var => Console.WriteLine($"    {var.Name}"));

            Console.ReadKey();
        }
    }
    
}
