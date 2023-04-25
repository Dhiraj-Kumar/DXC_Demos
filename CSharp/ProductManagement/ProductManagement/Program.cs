namespace ProductManagement
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
            Product[] products = new Product[10];
            products[0] = new Product() { Id = 1, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 };
            products[1] = new Product() { Id = 2, Name = "Camera", Brand = "Canon", Quantity = 7, Price = 45000 };

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}