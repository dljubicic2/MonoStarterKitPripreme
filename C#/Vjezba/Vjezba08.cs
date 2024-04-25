using System.Collections;
using System.Diagnostics.Tracing;

namespace VjezbaCollection
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Audi";
            car1.Model = "RS6";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Mercedes-Benz";
            car2.Model = "CLA 45S AMG";
            car2.VIN = "B2";

            Book book1 = new Book();
            book1.Name = "Lord of the rings";
            book1.Author = "Lord Lord";

            Book book2 = new Book();
            book2.Name = "The Pris apartment";
            book2.Author = "Lucy Foley";
            */


            // 1. Array lists:

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }   */



            // 2. List<T>

            /*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(book1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }   */


            // 3. Dictionary<TKey, TValue>

            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */


            //string[] names = { "Hugo", "Niko", "Jan" };
            // Object initializer
            /*
            Car car1 = new Car()
            {
                Make = "Volkswagen",
                Model = "Beetle",
                VIN = "C3"
            };
            Car car2 = new Car()
            {
                Make = "Rimac",
                Model = "Nevera",
                VIN = "D4"
            };
            */

            // 4. Collection initializer

            List<Car> myList = new List<Car>()
            {
                new Car
                {
                    Make = "Toyota",
                    Model = "Supra",
                    VIN = "E5"
                },

                new Car
                {
                    Make = "Peugeot",
                    Model = "3008",
                    VIN = "F6"
                }
            };


            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
