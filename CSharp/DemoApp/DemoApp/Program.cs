namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }
    }
}