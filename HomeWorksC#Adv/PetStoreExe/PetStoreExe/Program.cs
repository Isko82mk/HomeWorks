using System;
using PetStoreDomain.Core.Entities;
using PetStoreDomain.Core.Enum;


namespace PetStoreExe
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Cats
            Cat jony = new Cat("JonyBravo",Tipe.Cat,3,true,7);
            Cat bob = new Cat("BobSpeed", Tipe.Cat, 5, false, 5);
            Cat zack = new Cat("ZackFish", Tipe.Cat, 1, true, 5);
            Cat gilbert = new Cat("Gilber", Tipe.Cat, 2, false, 8);

            ////Dogs

            Dog jacky = new Dog("JackyJones",Tipe.Dog,1,"Bones",true);
            Dog indiana = new Dog("Indiana", Tipe.Dog, 2, "Rabit Meat", true);
            Dog filips = new Dog("Filips", Tipe.Dog, 5, "Dog Food", false);
            Dog zus = new Dog("Zus", Tipe.Dog, 6, "Bird Meat", true);

            ////Fish

            Fish cadys = new Fish("Candys",Tipe.Fish,1,"Silver Blue",12);
            Fish crisp = new Fish("Crisp", Tipe.Fish, 3, "GreenSilver", 5);
            Fish popaye = new Fish("Popaye", Tipe.Fish, 4, "Blue", 6);
            Fish brutus = new Fish("Brutus", Tipe.Fish, 3, "Green", 7);


            
           GenericPetStore<Pet> petList = new GenericPetStore<Pet>();

            petList.Add(jacky);
            petList.Add(indiana);
            petList.Add(filips);
            petList.Add(zus);

            petList.Add(jony);
            petList.Add(bob);
            petList.Add(zack);
            petList.Add(gilbert);

            petList.Add(cadys);
            petList.Add(crisp);
            petList.Add(popaye);
            petList.Add(brutus);



            petList.Print(jacky);
            petList.BuyPet("Indiana");
            petList.BuyPet("isko");

            Console.ReadKey();
        }
    }
}
