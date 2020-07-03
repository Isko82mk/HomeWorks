using System.Collections.Generic;

namespace Domain
{
    public static class DogOwners
    {
        public static List<Person> people = new List<Person>()
        {
            new Person("Freddy","Johnes",25),
             new Person("Nathen","Birns",15),
              new Person("Cristofer","Simpson",30),
               new Person("Erin","Black",33),
                new Person("Amelia","Fridrix",25),
                new Person("Raychel","Mark",19)

        };

        public static List<Dog> dogs = new List<Dog>()
        {
            new Dog ("Jacky","White",10),
             new Dog ("Billy","White",5),
              new Dog ("Franky","Brown",9),
               new Dog ("Max ","White",10),
                new Dog ("Rocky","Brown",6),
                 new Dog ("Toby","White",5),
                  new Dog ("Bear","YelowWhite",2),
                   new Dog ("Oscar","White",1),
                    new Dog ("Teddy","Brown",3),
                     new Dog ("Sammy","Brown",2),
                      new Dog ("Buch","Brown",4),
                       new Dog ("Cirbi","Black",8),
                        new Dog ("Fris","BrownWhite",3),

        };

        static DogOwners()
        {
            people[0].dogs = new List<Dog>() { dogs[0], dogs[5], dogs[7] };
            people[1].dogs = new List<Dog>() { dogs[1], dogs[6], dogs[4] };
            people[2].dogs = new List<Dog>() { dogs[2], dogs[3], };
            people[3].dogs = new List<Dog>() { dogs[9], dogs[8], dogs[11] };
            people[4].dogs = new List<Dog>() { dogs[12] };
            people[5].dogs = new List<Dog>() { dogs[10] };
        }





    }
}
