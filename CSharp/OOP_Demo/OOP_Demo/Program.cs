namespace OOP_Demo
{
    class Calculator
    {
        public void Show()
        {
            Console.WriteLine("This is Show Method");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public int Cube(int x)
        {
            return x * x * x;
        }

        public void Add(int a, int b=0, int c=0)
        {
            Console.WriteLine(a + b + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Show();
            calc.SayHello("John");
            calc.SayHello("James");
            calc.Sum(10, 20);
            int res = calc.Cube(5);
            Console.WriteLine(res);
            calc.Add(10, 20, 30);
        }
    }
}