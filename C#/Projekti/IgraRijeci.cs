namespace NameGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("************************");
                Console.WriteLine("***Reversed name game***");
                Console.WriteLine("************************");
                Console.WriteLine(" ");

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Enter your city where you live: ");
                string city = Console.ReadLine();
                Console.WriteLine(" ");

                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");


                char[] nameArray = name.ToCharArray();
                Array.Reverse(nameArray);

                char[] cityArray = city.ToCharArray();
                Array.Reverse(cityArray);

                char[] ageArray = age.ToString().ToCharArray();
                Array.Reverse(ageArray);


                string resault = " ";

                foreach (char itme in nameArray)
                {
                    resault += itme;
                }
                resault += " ";

                foreach (char itme in cityArray)
                {
                    resault += itme;
                }
                resault += " ";

                foreach (char itme in ageArray)
                {
                    resault += itme;
                }
                Console.WriteLine("Resaults: " + resault);

                Console.ReadLine();

                Console.Write("Would you like to try again? Type YES or No: ");
            } while (Console.ReadLine().ToUpper() == "YES");

        }
    }
}
