using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(58);
            newQueue.Enqueue(128);
            newQueue.Enqueue(58);
            newQueue.Enqueue(32);


            //IterateCollectoin(newQueue);
            // newQueue.Dequeue();
            //IterateCollectoin(newQueue);
            // newQueue.Dequeue();
            // IterateCollectoin(newQueue);


            // Console.WriteLine(newQueue.Count());//vrakja broj na elementi

            //Console.WriteLine(newQueue.Peek());//go zema prviot element od listata vo Quto;
            //Console.WriteLine(newQueue.Any()); ///true or false vrakja;
            //newQueue.Enqueue(38);
            //IterateCollectoin(newQueue);

            Queue<int> listOfNumbers = new Queue<int>();
            bool ifYes = true;
            while (ifYes)
            {
                Console.WriteLine("Do you whant to enter number? Y/N");
                string user = Console.ReadLine();

                if (user == "y" || user == "Y")
                {
                    Console.WriteLine("Enter number");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    listOfNumbers.Enqueue(userNumber);
                }
                else if ((user == "n" || user == "N" ) || user!="")
                {
                    break;
                }
                else
                {
                    ifYes = true;
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
