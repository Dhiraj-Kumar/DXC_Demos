using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace TableStorageDemo
{
    public class Product : ITableEntity
    {
        public string PartitionKey { get; set; } = Guid.NewGuid().ToString();
        public string RowKey { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public string ETag { get; set; }

        public void ReadEntity(IDictionary<string, EntityProperty> properties, OperationContext operationContext)
        {
            
        }

        public IDictionary<string, EntityProperty> WriteEntity(OperationContext operationContext)
        {
            IDictionary<string, EntityProperty> myProperties = TableEntity.Flatten(this, operationContext);
            myProperties.Remove("PartitionKey");
            myProperties.Remove("RowKey");
            myProperties.Remove("Timestamp");
            myProperties.Remove("ETag");
            return myProperties;
        }
    }
}
