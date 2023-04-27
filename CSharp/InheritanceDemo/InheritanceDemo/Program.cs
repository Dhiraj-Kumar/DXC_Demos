namespace InheritanceDemo
{
    class Calculator
    {
        protected string name;
        public Calculator()
        {
            Console.WriteLine("This is calculator class");
        }
        public Calculator(int x)
        {
            Console.WriteLine("This is another constructor of calculator");
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void Show()
        {
            Console.WriteLine("This is show method");
        }
    }

    class ScientificCalculator : Calculator
    {
        public ScientificCalculator() : base(10)
        {
            name = "John";
            Console.WriteLine("This is ScientificCalculator class");
        }

        public new void Show()
        {
            Console.WriteLine("This is show method of SciCalculator class");
        }
        public int Square(int x)
        {
            return x * x;
        }
        public int Cube(int x)
        {
            return x * x * x;
        }
        public int Factorial(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    class AICalculator : ScientificCalculator
    {
        public AICalculator()
        {
            Console.WriteLine("This is AI Calculator");
        }
        public void Message()
        {
            Console.WriteLine("Welcome to AI Calculator");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AICalculator calc = new AICalculator();
        }
    }
}