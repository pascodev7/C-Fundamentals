using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 25;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Pascal";
            bool isWorking = false;

            // Another war to declare data without precision on their types using the keyword 'var'
            var num = 26;
            var countable = 12;
            var price = 25.789f;
            var charact = 'B';
            var name = "Jeanty";
            var test = true;



            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // The second display
            Console.WriteLine( "\n\n");
            Console.WriteLine(num);
            Console.WriteLine(countable);
            Console.WriteLine(price);
            Console.WriteLine(charact);
            Console.WriteLine(name);
            Console.WriteLine(test);

            // Format string  to know the range types
            Console.WriteLine("\n\n");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue );
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // Declaring constants
            const float pi = 3.141516f;
            Console.WriteLine("\n\n");
            Console.WriteLine(pi);



        }
    }
}
