
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Error_handlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            try
            {
                throw new ArgumentNullException();
                //throw new Exception("I am an ERROR in  the try");/// trow e ekvivalntno na return vo funkcija.So trow se vrakja nevaldina vrednost.
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);

            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ ex.Message} from line 20");
            }
            finally
            {
                Console.WriteLine("Try again and enter adecuate value");
            }

            Console.ReadLine();
        }
    }
}
