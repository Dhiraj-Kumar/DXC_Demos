namespace PolymorphismDemo
{
    class Person
    {
        public virtual void Show()
        {
            Console.WriteLine("This is show method of Person class");
        }
    }
    class Student : Person
    {
        public override void Show()
        {
            Console.WriteLine("This is show method of Student class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.Show();
        }
    }
}