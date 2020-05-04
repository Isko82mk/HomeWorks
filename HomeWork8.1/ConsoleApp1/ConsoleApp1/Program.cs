using System;
using System.Resources;
using Domain;
using Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees alek = new Employees(12,"Aleksandar","Kocevski",Role.Manager,160,200);
        
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            Worker worker3 = new Worker();

            Worker[] workers = new Worker[] { worker1, worker2, worker3 };
            Manager deki = new Manager(1,"Dejan","Blazevski",Role.Manager,40,500,workers,500);

            Worker pero = new Worker(2,"Pero","Perovski",Role.Worker,40,500,deki);


            alek.SetSalary(80.50);
            deki.GiveTaks(worker1);
            deki.GiveTaks(worker3);
            worker3.DoTaska();

            EmployeeService empServ = new EmployeeService();

            Employees[] employees = new Employees[] {
            empServ.CreateEmployee(1,"Petar","Kocevski",Role.Worker,160,100),
            empServ.CreateEmployee(2,"Zoran","Kocev",Role.Finance,120,300),
            empServ.CreateEmployee(3,"Dragan","Acev",Role.SalesWorker,130,400),
            empServ.CreateEmployee(4,"Goran","Petrovski",Role.Manager,150,500),
             };




            Drink firstDrink = new Drink(2,false,6,"CockaCola",TypeFED.Drink,150,false);//ok
            Food firstFood = new Food(6, "Sheker", TypeFED.Food, 250.55, false, Taste.Sweet,2500.6);//ok
            Electronics firstElectronics = new Electronics(3, "Monitor LG5000", TypeFED.Electronics, 8500.9, true, 220);//ok

            Console.WriteLine(firstDrink.PrintInfo());
            Console.WriteLine(firstFood.PrintInfo());
            Console.WriteLine(firstElectronics.PrintInfo());
            firstFood.SetPrice(1600);
            firstDrink.SetPrice(100);
            firstElectronics.SetPrice(7999.9);

            Console.WriteLine(firstElectronics.TurnOn());
            Console.WriteLine(firstFood.ShowCalories());

            ProductServices productServce = new ProductServices();

            productServce.CreateFood(10,"Ketchup",TypeFED.Food,78.5,false,Taste.Salty,600.25);

            Product[] arrOfProducts = new Product[] {

                productServce.CreateFood(10,"Ketchup",TypeFED.Food,78.5,false,Taste.Salty,600.25),
                productServce.CreateFood(9,"Majo",TypeFED.Food,100,false,Taste.Salty,1500),
                productServce.CreateFood(8,"Spagety",TypeFED.Food,90,false,Taste.Sweet,255.5),
                productServce.CreateFood(7,"Flower",TypeFED.Food,500,false,Taste.Sweet,10000.25),
                productServce.CreateDrink(1,true,2,"Lozova",TypeFED.Drink,1500,false),
                productServce.CreateDrink(2,true,5,"Pelinkovac",TypeFED.Drink,1200,false),
                productServce.CreateDrink(1,true,6,"Vino",TypeFED.Drink,1000,false),
                productServce.CreateDrink(1,true,9,"Pivo",TypeFED.Drink,800,false),
                productServce.CreateElectronics(1,"PlasmaTV LG2000",TypeFED.Electronics,25500,false,220),
                productServce.CreateElectronics(4,"Fridge Beko ",TypeFED.Electronics,45500,false,220),
                productServce.CreateElectronics(7,"DishWasher LGWosh100",TypeFED.Electronics,20500,false,220),

            };

            Product[] employeeByRole = productServce.GetProductsByType(arrOfProducts,TypeFED.Drink);//Arr of products by TypeFED

            //Product[] newProduct = productServce.AddProduct(arrOfProducts, 2, "someSome", TypeFED.Drink, 26.56, false);


            foreach (Product role in employeeByRole)

            {
                Console.WriteLine($"{role.NameOfProduct}");
               
            }

            //foreach(Product product in arrOfProducts)
            //{
            //    Console.WriteLine($"{product.NameOfProduct}");
            //}


            //foreach (Employees employe in employees)
            //{
            //    Console.WriteLine(employe.Role);
            //}

            //Role newRole = Role.Manager;

            //Console.WriteLine($"From 45 line {empServ.GetEmployeesByRole(employees, newRole)}");

            //alek.OnHoliday();  //eror method OnHoliday from Employee...why??? :(
            ;

            //Console.WriteLine(deki.GetMontlySelary());


         

            Console.ReadLine();
        }
    }
}
