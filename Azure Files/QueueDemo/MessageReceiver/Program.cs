
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;

namespace MessageReceiver
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
            Console.WriteLine("---- Message Receiver ----");
            Console.WriteLine("Waiting for messages....");
            while (true)
            {
                CloudQueueMessage message = queue.GetMessage();
                if (message != null)
                {
                    Console.WriteLine(message.AsString);
                    queue.DeleteMessage(message);
                }
            }
        }
    }
}