using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // postfix increment
            int pap = 1;
            int pop = pap++;
            Console.WriteLine("\n" + "POSTFIX INCREMENT ---> ");
            Console.WriteLine(pap);
            Console.WriteLine(pop);

            // pREfix increment
            int papa = 1;
            int popo = ++papa;
            Console.WriteLine("\n" + "PREFIX INCREMENT ---> ");
            Console.WriteLine(papa);
            Console.WriteLine(popo);

            // Addition
            int a = 10;
            int b = 3;
            Console.WriteLine("\n" + "ADDITION ---> ");
            Console.WriteLine(a + b);

            // Division entiere
            int c = 10;
            int d = 3;
            Console.WriteLine("\n" + "DIVISION ENTIERE ---> ");
            Console.WriteLine(c / d);


            // Division reelle
            int e = 10;
            int f = 3;
            Console.WriteLine("\n" + "DIVISION ENTIERE ---> ");
            Console.WriteLine((float)e / (float)f);
        }
    }
}
