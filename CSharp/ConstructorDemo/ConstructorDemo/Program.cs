namespace ConstructorDemo
{
    class Demo
    {
        public Demo()
        {
            Console.WriteLine("I am constructor");
        }
        public Demo(int x)
        {
            Console.WriteLine("This is another constructor");
        }
        public void Show()
        {
            Console.WriteLine("This is show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Demo d2 = new Demo(10);
            d.Show();
        }
    }
}