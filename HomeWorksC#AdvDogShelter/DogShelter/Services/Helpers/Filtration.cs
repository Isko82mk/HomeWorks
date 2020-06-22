using DogShelter.Domain.Core.Enteties;
using DogShelter.Domain.DB;
using System;

namespace Services.Helpers
{
    public static class Filtration
    {

        public static void DogFiltration(Dog dog)
        {
            bool isValid = Dog.Validate(dog);

            if (isValid)
            {
                Console.WriteLine($"Dog { dog.Name}  have valid id and name ");
                  
              
                DogShelterDB.ListOfDogs.Add(dog);

                Console.WriteLine($"Dog with ID:{dog.Id} and Name:{ dog.Name} is addet to the dog shelter");
                //DogShelter.PrintAll(DogShelter.ListOfDogs);
            }
            else
            {
                Console.WriteLine("Dog does not have valid id or name");
            }

        }

    }
}
