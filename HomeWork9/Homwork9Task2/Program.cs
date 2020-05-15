using System;
using System.Collections;
using System.Collections.Generic;

namespace Homwork9Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> listOfNumbers = new Queue<int>();
            //bool ifYes = true;
            while (true)
            {
                Console.WriteLine("Do you whant to enter number? Y/N");
                string user = Console.ReadLine();

                if (user == "y" || user == "Y")
                {
                    Console.WriteLine("Enter number");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    listOfNumbers.Enqueue(userNumber);
                }
                else if ((user == "n" || user == "N") || user != "")
                {
                    break;
                }
               
            }
            IterateCollectoin(listOfNumbers);
            Console.ReadLine();
        }
        public static void IterateCollectoin(IEnumerable colection)
        {
            Console.WriteLine($"The numbers in the Q are :");
            foreach (var item in colection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
