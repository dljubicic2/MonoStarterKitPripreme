namespace Project01Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                double number1 = 0;
                double number2 = 0;
                double resault = 0;

                Console.WriteLine("******************");
                Console.WriteLine("****01 Project****");
                Console.WriteLine("Calculator program");
                Console.WriteLine("******************");

                Console.Write("Enter first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("+ = Add");
                Console.WriteLine("- = Subtract");
                Console.WriteLine("* = Multiplay");
                Console.WriteLine("/ = divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        resault = number1 + number2;
                        Console.WriteLine($"Your resault: {number1} + {number2} = " + resault);
                        break;

                    case "-":
                        resault = number1 - number2;
                        Console.WriteLine($"Your resault: {number1} - {number2} = " + resault);
                        break;

                    case "*":
                        resault = number1 * number2;
                        Console.WriteLine($"Your resault: {number1} * {number2} = " + resault);
                        break;

                    case "/":
                        resault = number1 / number2;
                        Console.WriteLine($"Your resault: {number1} / {number2} = " + resault);
                        break;

                    default:
                        Console.WriteLine("It is not a valid option! ");
                        break;
                }
                Console.WriteLine("Would you like to calculate again? Type YES or NO: ");
            } while (Console.ReadLine().ToUpper() == "YES");

            Console.WriteLine("***********************");
            Console.WriteLine("****** Good bye! ******");
            Console.WriteLine("*Thank you for playing*");
            Console.WriteLine("***********************");
            Console.ReadKey();
            
        }
    }
}