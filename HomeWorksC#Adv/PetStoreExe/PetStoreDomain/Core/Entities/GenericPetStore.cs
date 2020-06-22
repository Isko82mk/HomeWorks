using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStoreDomain.Core.Entities
{
    public class GenericPetStore<T> where T : Pet
    {

        private List<T> _petList;

        public GenericPetStore()
        {
            _petList = new List<T>();
        }

        // create,Read,Update,Delite 

        public void Add(T item)
        {
            _petList.Add(item);
        }

        public void Print(T tipe)
        {
            Console.WriteLine($"{tipe.Name} {tipe.Tipe} {tipe.Age}");
        }

        public void BuyPet(string name)
        {
            T item = _petList.FirstOrDefault(n => n.Name == name);

            if (item != null)
            {
                Console.WriteLine($"{item.Name} is in the shop");
                _petList.Remove(item);
                Console.WriteLine($"{item.Name} is sold");
            }
            else
            {
                Console.WriteLine("No pet by that name");
            }
        }



    }
}
