using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Xml.Linq;

namespace TableStorageDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con =
                "DefaultEndpointsProtocol=https;AccountName=stackroutestorage;AccountKey=wn8rN0RSrQm7YHPSrwr8g4F1n1ieV/bAs2FeW9p9DGR9Ag1J6R3kjlrkMR73bWQVtHqPMSb5XKZ5+ASt9YBZ9g==;EndpointSuffix=core.windows.net";
            CloudStorageAccount account = CloudStorageAccount.Parse(con);
            CloudTableClient client = account.CreateCloudTableClient();
            CloudTable table = client.GetTableReference("Product");
            table.CreateIfNotExistsAsync();
            var ops = TableOperation.Insert(new Product()
            {
                Name = "Laptop",
                Brand = "Dell",
                Quantity = 5,
                Price = 76000
            });
            
            var res = table.ExecuteAsync(ops);
            
            var entity = res.Result;
            Console.WriteLine(entity);

        }
    }
}