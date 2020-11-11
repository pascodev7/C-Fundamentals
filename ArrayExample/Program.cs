using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example with integer array
            int[] numbers = new int[3];
            numbers[0] = 3;
           
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine('\n');

            // Example with boolean array
            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            Console.WriteLine('\n');

            // Example with string array
            var names = new string[3] {"Ronaldo", "Dybala", "Cuadrado"};
            Console.WriteLine(names[0]);
            Console.WriteLine('\n');

            // second example with string array
            var lastNames = new string[3];
            lastNames[0] = "Cristiano";

            Console.WriteLine(lastNames[0]);
            Console.WriteLine(lastNames[1]);
            Console.WriteLine(lastNames[2]);
            Console.WriteLine('\n');
        }
    }
}
