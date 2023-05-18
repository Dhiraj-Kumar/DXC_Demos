using AppLibrary.Tests;

namespace AppLibrary
{
    public class FileReader: IFileReader
    {
        public string ReadText()
        {
            return File.ReadAllText("E:\\DXC_Demo_Files\\File1.txt");
        }
    }
}