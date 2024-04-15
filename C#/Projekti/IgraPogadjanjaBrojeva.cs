namespace Project02GuessingGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isCorrectGuess = false;

            Random random = new Random();
            int randomNumber = new Random().Next(1,11);
            
            Console.WriteLine("**************************");
            Console.WriteLine("***Guessing number game***");
            Console.WriteLine("**************************");

            Console.WriteLine("A number between 1 and 10 will be generated: ");
            Console.WriteLine("If you guess the correct number, you will win: ");

            Console.WriteLine(randomNumber);

            while (!isCorrectGuess)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNumber)
                {
                    Console.WriteLine("Your guess is wrong! ");
                }
                else if(guess < randomNumber)
                {
                    Console.WriteLine("Your guess is wrong! ");
                }
                else
                {
                    Console.WriteLine("Correct! ");

                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congratulations you won the game! ");


            Console.ReadKey();
        }
    }
}
