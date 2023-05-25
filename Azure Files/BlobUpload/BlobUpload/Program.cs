using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace BlobUpload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con =
                "DefaultEndpointsProtocol=https;AccountName=stackroutestorage;AccountKey=ZudZXtqhDwiE0rRgpmQCGy3xdHCe1kCwJNovablTyb6DNR3ZDXit0KbIJRL9jouVDot7B5Cf27cu+AStOmZdZw==;EndpointSuffix=core.windows.net";
            CloudStorageAccount csa = CloudStorageAccount.Parse(con);
            CloudBlobClient cbc = csa.CreateCloudBlobClient();

            Console.WriteLine("Getting reference of container");
            CloudBlobContainer container = cbc.GetContainerReference("democontainer");
            
            container.CreateIfNotExists();

            string[] fileEntries = Directory.GetFiles("E:\\DXC_Demo_Files\\Azure Files\\Files");
            foreach (var f in fileEntries)
            {
                string key = Path.GetFileName(f);
                UploadBlob(container, key, f);
            }

        }

        private static void UploadBlob(CloudBlobContainer container, string key, string filename)
        {
            Console.WriteLine("Uploading file...." + filename);
            CloudBlockBlob b = container.GetBlockBlobReference(key);

            using (var fs = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                b.UploadFromStream(fs);
            }

            Console.WriteLine("File Upload Completed");
        }
    }
}