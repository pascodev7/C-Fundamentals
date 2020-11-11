using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 10;
            byte b = (byte) i;
            Console.WriteLine(b);

            var number = "1234";
            int j = Convert.ToInt32(number);
            Console.WriteLine(j);

            // Handling the exception
            try
            {
                byte k = Convert.ToByte(number);
                Console.WriteLine(j);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte... It's a too large number");
            }

            try
            {
                string str = "True";
                bool x = Convert.ToBoolean(str);
                Console.WriteLine(x);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte... It's a too large number");
            }

            

        }
    }
}
