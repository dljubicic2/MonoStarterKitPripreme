namespace KvizApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****************");
            Console.WriteLine("*** Kviz app ***");
            Console.WriteLine("****************");
            Console.WriteLine(" ");

            string[] questions =
            {
                "What is the biggest ocean in the world? ",
                "Who invented electricity? ",
                "What is biggest country in North America? "
            };


            string[] answers =
            {
                "a) Atlantic ocean \n b) Pacific ocean \n c) Indian ocean",
                "a) Nikola Tesla \n b) Thomas Edison \n c) Neil Amstrong ",
                "a) Mexico \n b) USA \n c) Canada"
            };

            int[] correctAnswers = { 1, 0, 2 };
            int playerScore = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine("Question: " + (i + 1));
                Console.WriteLine(questions[i]);
                Console.WriteLine(" ");
                Console.WriteLine(answers[i]);

                Console.WriteLine(" ");
                Console.Write("Enter you answer: a), b) or c): ");

                string playerAnswer = Console.ReadLine();


                if(string.Equals(playerAnswer, "b)") && correctAnswers[i] == 1)
                {
                    playerScore++;
                    Console.WriteLine("Correct!");
                }
                else if(string.Equals(playerAnswer, "a)") && correctAnswers[i] == 0)
                {
                    playerScore++;
                    Console.WriteLine("Correct!");
                }
                else if(string.Equals(playerAnswer, "c)") && correctAnswers[i] == 2)
                {
                    playerScore++;
                    Console.WriteLine("Correct!");
                }
            }

            Console.WriteLine("Your score is: " + playerScore + "/" + questions.Length);
        }
    }
}
