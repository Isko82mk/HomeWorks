using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Part> parts = new List<Part>();

            parts.Add(new Part() { PartName = "crak Arm",PartID= 1334, } );
            parts.Add(new Part() { PartName = "regular seat", PartID = 1434, });
            parts.Add(new Part() { PartName = "banana seat", PartID = 1444, });
            parts.Add(new Part() { PartName = "cassette", PartID = 1534, });
            parts.Add(new Part() { PartName = "shift lever", PartID = 1634, });



            foreach (Part part in  parts)
            {
                Console.WriteLine(part.PartName,part.PartID);
            }




            Console.ReadLine();
        }



    }




}
