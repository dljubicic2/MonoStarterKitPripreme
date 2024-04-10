using System.Globalization;

namespace Vjezba04Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pogrešan način
            /* 
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 25;

            if(number1 == 16)
            {

            }
            else if(number2 == 16)
            {

            }
            else if(number3 == 16)
            {

            }
            */



            /*
            // Ispravan način
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 15;
            numbers[4] = 23;
            //numbers[5] = 42;

            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length); //lenght koristimo kada želimo saznati koliko imamo elemenata u nizu
            Console.ReadLine();
            */

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 48 };

            //Array s stringom
            //string[] names = new string[] { "Eddie", "Alex", "Michael", "David", "Lee" };

            /*
            for (int i = 0; i < names.Length; i++) // Ova funkcija će ispisati sve elemente niza
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */


            // Drugi primjer:
            /*foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            
            
            
            //Obrunuti redoslijed vrijednosti
            string zig = "You can get what you want out of life " +
                "if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();  //char koristimo kada želimo izvući samo jednu vrijednost
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }
            Console.ReadLine();




        }
    }
}
