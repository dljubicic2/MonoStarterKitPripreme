namespace ScopeAndAccessibilityModifiers
{
    class Program
    {
        private static string k = "";
        
        
        public static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if(i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l); // Ne može se izvesti jer smo deklarirali
                                        // string unutar if.
            }

            //Console.WriteLine(i); // Ne može se izvesti jer je i izvan bloka koda
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.doSomething();

            Console.ReadLine();


        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
     
    }


    // Accessibility Modifiers
    class Car
    {
        public void doSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World";
        }
    }
}