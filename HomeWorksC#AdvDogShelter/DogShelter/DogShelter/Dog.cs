using System;

namespace DogShelter
{
    public class Dog
    {
        private int _id;
        private string _name;
        public string Color { get; set; }

        public Dog() { }

        public static bool Validate(Dog dog)
        {

            if (dog.Id > 0 && dog.Name.ToCharArray().Length >= 2)
            {
                //Console.WriteLine($"Dog  have valid id  - {dog.Id} an name { dog.Name}");
                return true;
            }
            else
            {
                //Console.WriteLine("Dog dos note have  a valid id or name");
                return false;
            }

        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
