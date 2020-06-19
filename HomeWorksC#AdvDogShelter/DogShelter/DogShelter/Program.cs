using System;

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


            //Dog.Validate(jony);
            //Dog.Validate(mike);
            //Dog.Validate(persi);

            Filtration(jony);
            Filtration(mike);
            Filtration(persi);
            Filtration(jecky);
            Filtration(suzi);
            DogShelter.PrintAll(DogShelter.ListOfDogs);


            Console.ReadKey();
        }

        public static void Filtration(Dog dog)
        {
           bool isValid=Dog.Validate(dog);

            if (isValid)
            {
                Console.WriteLine($"Dog { dog.Name}  have valid id and name ");

                DogShelter.ListOfDogs.Add(dog);
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
