using CSharpClasses.Math;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pascal = new Person();
            pascal.FirstName = "Pascal";
            pascal.LastName = "Jeanty";
            pascal.introduce();

            var calculator = new Calculator();
            var result = calculator.add(25, 75);
            System.Console.WriteLine(result);
        }
    }
}
