using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle atOnePositin = vehicles.ElementAt(1);
            //Vehicle atFirst = vehicles.First();

            //Vehicle atLast = vehicles.Last(v=>v.Brand==Brand.Audi);

            List<int> yugoAge = vehicles.Select(v => v.Year).ToList();
            List<string> yugoColor = vehicles.Select(v => v.Color).ToList();
            List<Brand> yugoBrand = vehicles.Select(v => v.Brand).ToList();



            List<Vehicle> YearByAsc = vehicles.OrderBy(v =>v.Year).ToList();
            List<Vehicle> brandByAsc = vehicles.OrderBy(v => v.Brand).ToList();
            List<Vehicle> colorByAsc = vehicles.OrderBy(v => v.Color).ToList();

            List<Vehicle> yugo = vehicles .OrderBy(v => v.Year)
                                        
                                          .OrderBy(v=>v.Color)
                                          .ToList();
                                           

            //PrintValues(YearByAsc);
            //PrintValues(brandByAsc);
            //PrintValues(colorByAsc);
            //PrintValues(yugo);

            List<Vehicle> yugoCar = vehicles.Where(v=>v.Brand == Brand.Yugo).ToList();

            Vehicle firstYugo = vehicles.Single(v => v.Color == "green");

            PrintValues(yugoCar);
            PrintCar(firstYugo);
            // PrintValues(vehicles);
            //Console.WriteLine(atOnePositin.Brand);
            //Console.WriteLine(atFirst.Brand);



            Console.ReadLine();
        }

        static  List<Vehicle> vehicles { get; set; } = new List<Vehicle>
            {
                new Vehicle{Brand=Brand.Yugo,Color="red",Year=1988 },
                new Vehicle{Brand=Brand.Fiat101,Color="green",Year=1988 },
                new Vehicle{Brand=Brand.Opel,Color="red",Year=1978 },
                new Vehicle{Brand=Brand.Ficho,Color="red",Year=1990 },
                new Vehicle{Brand=Brand.Fiat101,Color="white",Year=1989 },
                new Vehicle{Brand=Brand.Audi,Color="red",Year=1988 },
                new Vehicle{Brand=Brand.Fiat101,Color="red",Year=1990 },
                new Vehicle{Brand=Brand.Opel,Color="red",Year=1988 },
                new Vehicle{Brand=Brand.Fiat101,Color="red",Year=1988 },
                new Vehicle{Brand=Brand.Opel,Color="red",Year=1990 },
                new Vehicle{Brand=Brand.Yugo,Color="green",Year=1988 },
                new Vehicle{Brand=Brand.Fiat101,Color="green",Year=1988 },
                new Vehicle{Brand=Brand.Opel,Color="red",Year=1978 },
                new Vehicle{Brand=Brand.Ficho,Color="yellow",Year=1990 },
                new Vehicle{Brand=Brand.Fiat101,Color="white",Year=1989 },
                new Vehicle{Brand=Brand.Audi,Color="red",Year=1988 },
                new Vehicle{Brand=Brand.Fiat101,Color="red",Year=1990 },
                new Vehicle{Brand=Brand.Opel,Color="red",Year=1988 },
                new Vehicle{Brand=Brand.Fiat101,Color="yellow",Year=1988 },
                new Vehicle{Brand=Brand.Opel,Color="red",Year=1990 }
            };

        public static void PrintCar(Vehicle vehicle)
        {
            Console.WriteLine($"{vehicle.Brand}{vehicle.Color} {vehicle.Year}");
        }


        public static void PrintValues(List<Vehicle> list) {

            Console.WriteLine("List of cars :");
            Console.WriteLine("-------------------------------");
            string brand, color, year;
            brand = "BRAND";
            color = "COLOR";
            year = "YEAR";
            Console.WriteLine($"{brand,10} {color,10} {year,10}");
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Brand,10} {item.Color,10} {item.Year,10}");
               
            }
        }



    }
}
