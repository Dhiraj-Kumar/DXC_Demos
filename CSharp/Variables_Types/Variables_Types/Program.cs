namespace Variables_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //Variable Declaration
            x = 10; //Variable Assignment

            int y = 20; //Variable declaration with assignment
            const int z = 30;

            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = num1 + num2;
            Console.WriteLine(num3);

            float a = 2.5f;
            decimal b = 3.4M;

            bool isCompleted = true;
        }
    }
}