using Unity;
namespace DependencyInjecttionExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IMyinterface, Class1>();

            var obj = container.Resolve<Class2>();

            obj.Run();
        }
    }

    interface IMyinterface
    {
        void Show();
    }
    class Class1 : IMyinterface
    {
        public void Show()
        {
            Console.WriteLine("This is Show Method");
        }
    }

    class NewClass : IMyinterface
    {
        public void Show()
        {
            Console.WriteLine("This is new Show method");
        }
    }


    class Class2
    {
        private readonly IMyinterface _myinterface;

        public Class2(IMyinterface myinterface)
        {
            _myinterface = myinterface;
        }

        public void Run()
        {
            _myinterface.Show();
        }
    }
}