using Unity;

namespace DependencyInjectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IDAL, DAL>();

            var service = container.Resolve<Service>();
            service.PrintData();
        }
    }
}