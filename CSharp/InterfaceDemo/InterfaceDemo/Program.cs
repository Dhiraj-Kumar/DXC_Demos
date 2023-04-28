namespace InterfaceDemo
{
    interface IMyInterface
    {
        void Sum(int a, int b);
        void Multiply(int a, int b);
    }
    interface IMyInterface2 : IMyInterface
    {
        void Cube(int x);
    }
    class Demo
    {
        public void Show()
        {
            Console.WriteLine("This is show");
        }
    }

    class Class1 : IMyInterface2
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Cube(int a)
        {
            Console.WriteLine(a * a * a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMyInterface2 obj = new Class1();
            obj.Sum(10, 20);
        }
    }
}