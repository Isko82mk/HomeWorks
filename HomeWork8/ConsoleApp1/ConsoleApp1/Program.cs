using Domain;
using Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee isko = new Employee("Ivica", "Janevski", 25000);

            EmployeeServices services = new EmployeeServices();

            services.PrintInfo(isko);
            services.GetSalary(isko);
            Console.WriteLine(services.GetSalary(isko));



            Console.ReadLine();



        }
    }
}
