using MyLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Sum(10,20));
            Console.ReadLine();

        }
    }
}