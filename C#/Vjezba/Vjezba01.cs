using System.Reflection.Metadata;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // if, else if and else statements
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";
            
            if(userValue == "1")
                message = "You won a new car!";
            else if(userValue == "2")
                message = "You won a new boat! ";
            else if(userValue == "3")
                message = "You won a new cat! ";
            else
            {
                message = "Sorry, we didn't understand";
                //message = message + "You lose.";
                message += "You Lose";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */



            // Conditional operators
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "stand of lint";

            //Console.WriteLine("You won a ");
            //Console.WriteLine(message);
            //Console.WriteLine(".");

            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered: {0}, there for you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}
