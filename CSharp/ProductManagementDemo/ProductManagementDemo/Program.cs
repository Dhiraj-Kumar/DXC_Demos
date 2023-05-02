namespace ProductManagementDemo
{
    //CRUD - Create, Retrieve, Update, Delete
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    class Management
    {
        List<Product> products;
        public Management()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name="Laptop", Brand="Dell", Quantity=4, Price=65000},
                new Product { Id = 2, Name="Camera", Brand="Canon", Quantity=8, Price=78000},
            };
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product GetProduct(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                    return product;
            }
            return null;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public bool DeleteProduct(int id)
        {
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    products.Remove(p);
                    return true;
                }
            }
            return false;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Management obj = new Management();
            string ans = "";
            do
            {
                Console.WriteLine("Welcome to Product Management App");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Get Product By Id");
                Console.WriteLine("3. Get All Products");
                Console.WriteLine("4. Delete Product By Id");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Product Id");
                            int id = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter Product Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Product Brand");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Enter Product Quantity");
                            int qty = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter Product Price");
                            int price = Convert.ToInt16(Console.ReadLine());
                            obj.AddProduct(new Product() { Id = id, Name = name, Brand = brand, Quantity = qty, Price = price });
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Product Id");
                            int id = Convert.ToInt16(Console.ReadLine());
                            Product? p = obj.GetProduct(id);
                            if (p == null)
                            {
                                Console.WriteLine("Product with specified id does not exists");
                            }
                            else
                            {
                                Console.WriteLine($"{p.Id} {p.Name} {p.Brand} {p.Quantity} {p.Price}");
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (var p in obj.GetProducts())
                            {
                                Console.WriteLine($"{p.Id} {p.Name} {p.Brand} {p.Quantity} {p.Price}");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter Product Id");
                            int id = Convert.ToInt16(Console.ReadLine());
                            if (obj.DeleteProduct(id))
                            {
                                Console.WriteLine("Product Deleted Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Product with specified id does not exist");
                            }
                            break;
                        }
                }
                Console.WriteLine("Do you wish to continue? [y/n] ");
                ans = Console.ReadLine();
            } while (ans.ToLower() == "y");
        }
    }
}