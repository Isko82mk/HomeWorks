using System;

namespace pom1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string userImput = Console.ReadLine();
            string upperUserImput = char.ToUpper(userImput[0]) + userImput.Substring(1);


            Console.WriteLine($"form line 12 { upperUserImput }");


            //Console.WriteLine($"form line 12 {char.ToUpper(userImput[0]) + userImput.Substring(1)}");



            Console.ReadLine();
        }
    }
}
