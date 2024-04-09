using System.Net.Http.Headers;

namespace Vjezba03WhilePetlja
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu) 
            {
                displayMenu = MainMenu();
            }
            MainMenu();   
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing game");
            Console.WriteLine("3) Exit");
            string resault = Console.ReadLine();
            if(resault == "1")
            {
                PrintNumbers();
                return true;
            }
            else if(resault == "2")
            {
                GuessingGame();
                return true;
            }
            else if(resault == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int resault = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < resault + 1)
            {
                Console.WriteLine(counter);
                Console.WriteLine("_");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string resault = Console.ReadLine();
                guesses++;

                if (resault == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong! It took you guesses", guesses);

            } while (incorrect);
                Console.WriteLine("Correct");
            

            Console.ReadLine();
        }
    }
}
