using System;

namespace Domain
{
   public class Cat : Pet
    {
        public override string Name { get; set; }
        public override Tipe Tipe { get; set; }
        public override int Age { get; set; }

        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, Tipe tipe, int age,bool isLazy, int livesLeft)
        {
            Name = name;
            Tipe = tipe;
            Age = age;
            IsLazy = isLazy;
            LivesLeft = livesLeft;

        }
        public override void PrintInfo()
        {
            Console.WriteLine($" {Name} {Tipe} { Age} ");
        }
    }
}
