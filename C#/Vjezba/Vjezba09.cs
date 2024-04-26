using System.Threading.Channels;

namespace VjezbaLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();

            List<Car> myCars = new List<Car>()
            {
                new Car() { Make = "Renault", Model = "Clio", Year = 2013, Price = 7200, VIN = "R1"},
                new Car() { Make = "SAAB", Model = "9-3", Year = 2004, Price = 2400, VIN = "S2"},
                new Car() { Make = "Ford", Model = "Mustang", Year = 2015, Price = 22450, VIN = "F3"},
                new Car() { Make = "Volkswagen", Model = "Golf", Year = 2011, Price = 6500, VIN = "V4"},
                new Car() { Make = "Mini", Model="One", Year = 2009, Price = 4200, VIN = "M5"},
                new Car() { Make = "Ford", Model = "F150", Year = 2022, Price = 45000, VIN = "F6"}
            };


            // LINQ query

            /*
            var fords = from Car in myCars
                        where Car.Make == "Ford"
                        && Car.Year == 2009 // Dodavanje dodatnog kriterija
                        select Car;
            */


            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */


            // LINQ method

            //var fords = myCars.Where(f => f.Make == "Ford" && f.Year == 2022);

            //var orderCars = myCars.OrderByDescending(p => p.Year);

            /*
            var firstSaab = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "SAAB");
            Console.WriteLine(firstSaab.VIN);
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year >2010));

            //myCars.ForEach(p => p.Price -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:c}", p.VIN, p.Price));

            //Console.WriteLine(myCars.Exists(p => p.Model == "Clio"));

            //Console.WriteLine(myCars.Sum(p => p.Price)); 

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }
            */


            
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            var volkswagens = myCars.Where(v => v.Make == "Volkswagen" && v.Year == 2011);
            Console.WriteLine(volkswagens.GetType());

            var newCars = from car in myCars
                              where car.Make == "Volkswagen"
                              && car.Year == 2011
                              select new {car.Make, car.Model };
            Console.WriteLine(newCars.GetType());


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string VIN { get; set; }

    }
}
