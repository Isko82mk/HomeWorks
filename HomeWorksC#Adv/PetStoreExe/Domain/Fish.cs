using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
  public  class Fish : Pet
    {
        public override string Name { get; set; }
        public override Tipe Tipe { get; set; }
        public override int Age { get; set; }

        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name,Tipe tipe,int age, string color, int size)
        {
            Name = name;
            Tipe = tipe;
            Age = age;
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($" {Name} {Tipe} { Age} {Color} {Size}");
        }
    }
}
