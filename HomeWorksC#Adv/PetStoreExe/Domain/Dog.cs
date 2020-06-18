using System;

namespace Domain
{
   public class Dog : Pet
    {
        public override string Name { get; set; }
        public override Tipe Tipe { get; set; }
        public override int Age { get; set; }
        public string FavoriteFood { get; set; }
        public bool IsGoodBoy { get; set; }


        public Dog() { }


        public Dog(string name, Tipe tipe, int age, string favoriteFood,bool isGoodBoy)
        {
            Name = name;
            Tipe = tipe;
            Age = age;
            FavoriteFood = favoriteFood;
            IsGoodBoy = isGoodBoy;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Tipe} { Age} {FavoriteFood} {IsGoodBoy}");
        }
    }
}
