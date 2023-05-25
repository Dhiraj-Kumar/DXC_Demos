using Unity;

namespace BookStore
{
    public class Program
    {
        //private readonly IBookService _bookService;

        //public Program(IBookService bookService)
        //{
        //    _bookService = bookService;
        //}

        private readonly IBookRepository _repository;

        public Program(IBookRepository repository)
        {
            _repository = repository;
        }

        public int Run(string name, string author, int price)
        {
            return _repository.AddBook(name, author, price);
        }

        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IBookRepository, BookRepository>();
            container.RegisterType<IBookService, BookService>();

            var program = container.Resolve<Program>();
            Console.WriteLine("Enter Book Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Author Name");
            string author = Console.ReadLine();
            Console.WriteLine("Enter Book Price");
            int price = Convert.ToInt16(Console.ReadLine());
            program.Run(name, author, price);
        }
    }
}