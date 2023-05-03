namespace LinqDemo
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1. Define DataSource
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name="Laptop", Brand="Dell", Quantity=5, Price=46500},
                new Product { Id = 2, Name="Camera", Brand="Canon", Quantity=7, Price=32300},
                new Product { Id = 3, Name="Tablet", Brand="Lenovo", Quantity=2, Price=18500},
                new Product { Id = 4, Name="Desktop", Brand="HP", Quantity=9, Price=78200},
                new Product { Id = 5, Name="Earphones", Brand="Boat", Quantity=3, Price=3000},
                new Product { Id = 6, Name="Mobile", Brand="Apple", Quantity=4, Price=84000},
            };

            //Step 2. Write Query
            //var query = from x in products where x.Id == 3 select x;

            //var result = products.Where(x => x.Id == 1).ToList();
            //var item = products.Find(x => x.Id == 1);
            var item = products.Where(x => x.Price == products.Min(p => p.Price)).FirstOrDefault();

            Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");
            
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");
            //}
        }
    }
}