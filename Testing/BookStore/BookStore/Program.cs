using Unity;

namespace BookStore
{
    public class Program
    {
        private readonly IBookRepository _bookRepository;

        public Program(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public int Run()
        {
            Console.WriteLine("Enter Book Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Author Name");
            string author = Console.ReadLine();
            Console.WriteLine("Enter Book Price");
            int price = Convert.ToInt16(Console.ReadLine());
            return _bookRepository.AddBook(name, author, price);
        }

        static void Main(string[] args)
        {
            //var container = new UnityContainer();
            //container.RegisterType<IBookRepository, BookRepository>();

            //var program = container.Resolve<Program>();
            //program.Run();
        }
    }
}