namespace StaticDemo
{
    class Demo
    {
        public static int num = 0;
        public void Increment()
        {
            num++;
            Console.WriteLine(num);
        }

        public static void Show()
        {
            Console.WriteLine("This is Show Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Demo d2 = new Demo();
            Demo d3 = new Demo();
            d1.Increment();
            d2.Increment();
            d3.Increment();

            Demo.Show();
            
        }
    }
}

// Type of Access Specifier
// 1. public - Can access anywhere
// 2. private - Can access only inside the class
// 3. internal - Can access within the assembley
// 4. protected - Can access within the class or its derived classes
// 5. protected internal - Comprise the features of protected as well as internal