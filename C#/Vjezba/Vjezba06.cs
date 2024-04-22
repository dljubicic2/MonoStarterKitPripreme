using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace KlaseVjezba
{
    class Program
    {
        public static void Main(string[] args)
        {
           Car myCar = new Car(); // Kreiranje instance klase

            myCar.Make = "Toyota";
            myCar.Model = "Land Cruiser";
            myCar.Year = 2024;
            myCar.Color = "White";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100000;
            return carValue;
        }
    }

    class Car   // Kreiranje nove klase
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Kreiranje metode unutar klase

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1999)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
                
        }
    }
}
