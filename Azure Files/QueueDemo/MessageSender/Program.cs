using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;

namespace MessageSender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con =
                "DefaultEndpointsProtocol=https;AccountName=stackroutestorage;AccountKey=ZudZXtqhDwiE0rRgpmQCGy3xdHCe1kCwJNovablTyb6DNR3ZDXit0KbIJRL9jouVDot7B5Cf27cu+AStOmZdZw==;EndpointSuffix=core.windows.net";
            CloudStorageAccount account = CloudStorageAccount.Parse(con);
            CloudQueueClient client = account.CreateCloudQueueClient();
            CloudQueue queue = client.GetQueueReference("myqueue");
            queue.CreateIfNotExists();
            Console.WriteLine("---- Message Sender ----");
            while (true)
            {
                Console.WriteLine("Type Your Message");
                string msg = Console.ReadLine();
                CloudQueueMessage message = new CloudQueueMessage(msg);
                queue.AddMessage(message);
                Console.WriteLine("Message Sent!");
            }
        }
    }
}