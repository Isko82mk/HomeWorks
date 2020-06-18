using System;
using Domain;
namespace PetStoreExe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cats
            Cat jony = new Cat("JonyBravo",Tipe.Cat,3,true,7);
            Cat bob = new Cat("BobSpeed", Tipe.Cat, 5, false, 5);
            Cat zack = new Cat("ZackFish", Tipe.Cat, 1, true, 5);
            Cat gilbert = new Cat("Gilber", Tipe.Cat, 2, false,8);

            //Dogs

            Dog jacky = new Dog("JackyJones",Tipe.Dog,1,"Bones",true);
            Dog indiana = new Dog("Indiana", Tipe.Dog, 2,"Rabit Meat",true);
            Dog filips = new Dog("Filips", Tipe.Dog, 5,"Dog Food",false);
            Dog zus = new Dog("Zus", Tipe.Dog, 6,"Bird Meat",true);

            //Fish

            Fish cadys = new Fish("Candys",Tipe.Fish,1,"Silver Blue",12);
            Fish crisp = new Fish("Crisp", Tipe.Fish, 3,"GreenSilver",5);
            Fish popaye = new Fish("Popaye", Tipe.Fish, 4,"Blue",6);
            Fish brutus = new Fish("Brutus", Tipe.Fish, 3,"Green",7);

            GenericPetStore<Dog> dogs = new GenericPetStore<Dog>();

            dogs.Add(jacky);
            dogs.Add(indiana);
            dogs.Add(filips);
            dogs.Add(zus);

            GenericPetStore<Cat> cats = new GenericPetStore<Cat>();

            cats.Add(jony);
            cats.Add(bob);
            cats.Add(zack);
            cats.Add(gilbert);

            GenericPetStore<Fish> fish = new GenericPetStore<Fish>();
            fish.Add(cadys);
            fish.Add(crisp);
            fish.Add(popaye);
            fish.Add(brutus);

            GenericPetStore<Pet> pets = new GenericPetStore<Pet>();
            
            pets.Add(jony);
            pets.Add(bob);
            pets.Add(zack);
            pets.Add(gilbert);

            pets.Add(jacky);
            pets.Add(indiana);
            pets.Add(filips);
            pets.Add(zus);

            pets.Add(cadys);
            pets.Add(crisp);
            pets.Add(popaye);
            pets.Add(brutus);

            pets.Print(jacky);


            pets.BuyPet("Indiana");
            fish.BuyPet("isko");
            cats.BuyPet("ZackFish");












            Console.ReadKey();
        }
    }
}
