using System;
using System.Collections.Generic;
using System.Linq;

namespace pom2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("");

            //Where()
            //First(),Last()
            //Select()
            //ToList()

            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name="Sparky",Age=2,Breed=Breed.Bulldog},
                new Dog(){Name="Buch",Age=1,Breed=Breed.Labrador},
                new Dog(){Name="Zoe",Age=3,Breed=Breed.Pudlica},
                new Dog(){Name="Sia",Age=1,Breed=Breed.Labrador},
                new Dog(){Name="Willia,",Age=4,Breed=Breed.Labrador},
                new Dog(){Name="Buck",Age=2,Breed=Breed.Pudlica},
                new Dog(){Name="Tom",Age=2,Breed=Breed.Bulldog},
                new Dog(){Name="Billy",Age=2,Breed=Breed.Bulldog},
                new Dog(){Name="Billy",Age=3,Breed=Breed.Labrador},
                new Dog(){Name="Tom",Age=5,Breed=Breed.Pudlica},

            };

            dogs.ElementAt(1);///eleement na pozicija 1

            //Console.WriteLine(dogs.ElementAt(1).Name);


            //where metodata e ekvivalne na filter;
            //dogs.filiter(x=x.age ===17) u JS;

            List<Dog>dogsWhitAgeOne=dogs.Where(d => d.Age == 2).ToList();

            //PrintColection(dogsWhitAgeOne);

            Dog sparky = dogs.Single(d=>d.Name=="Sparky");//ovoj metod funkcionira samo ako ima eden element so ime Sparky;Se upotrebuva koa imame ID;
            //PrintDog(sparky);                             //ako ima dva eleemnti so ime sparky kje frli greshka = RunTimeExeption;


            Dog billy = dogs.First(d=> d.Name=="Billy");  ///go selectira prviot element vo listtata so ime billy;
            //PrintDog(billy);

            Dog tom = dogs.FirstOrDefault(d => d.Name == "Tom");// ako posti elementot go vrakja elementot ako ne vrakja Null;
                                                                //PrintDog(tom);

             Dog blly1 = dogs.Last(x=>x.Name=="Billy");//kje go selektira posledniot Billy sho e vo listtata
             Dog tom2 = dogs.Last(d=>d.Name=="Tom");/// kje go selektira posledniot Tom vo listata;
            //PrintDog(blly1);
            //PrintDog(tom2);

             Dog oldestDog = dogs.LastOrDefault(d=>d.Age > 20);
            //PrintDog(oldestDog);

            //// do ovde ovie bea metodi za filtracija
            ///
            // ------------------------------------------------

            /// MAPIRANJE ODNOSNO SELECT
            // Select () =====>  vo JS map;

            List<string>names= dogs.Select(d=>d.Name).ToList();
            List<int> ages = dogs.Select(d => d.Age).ToList();  ///// Kako generichka metoda da se napravi?
            List<Breed> breds = dogs.Select(d => d.Breed).ToList();

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //OrderBy ======> vo JS map

            List<Dog> dogsByAgeAsc = dogs.OrderBy(d => d.Age).ToList(); // Gi sortira spored vrednost na age rastechki
            //PrintColection(dogsByAgeAsc);


            List<Dog> dogsByNameAsc = dogs.OrderBy(d => d.Name)
                                          .OrderBy(d => d.Age)
                                           .ToList();

            //PrintColection(dogsByNameAsc);

            List<Dog> dogsByDes = dogs.OrderByDescending(d => d.Name)
                                      .OrderByDescending(d => d.Age)
                                      .ToList();

            PrintColection(dogsByDes);


            Console.ReadLine();
        }

        public static void PrintDog(Dog dog)
        {
            if (dog != null)//poradi FirstOrDefault()--za da ne ni padne programata  bidejkji vrakja Null;
                Console.WriteLine($"{dog.Name}  {dog.Age} {dog.Breed}");
            else
                Console.WriteLine("Dog is null");
        }
        public static void PrintColection(List<Dog> colection)
        {

            foreach (var item in colection)
            {
                Console.WriteLine($"{item.Name}  {item.Age} {item.Breed}");
            }

        }

        public enum Breed
        {
            Bulldog,
            Pudlica,
            Labrador
        }

        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Breed Breed { get; set; }

        }
    }
}
