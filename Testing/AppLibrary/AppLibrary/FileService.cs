using AppLibrary.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class FileService
    {
        private IFileReader _reader;
        public FileService(IFileReader reader)
        {
            _reader = reader;
        }

        public string ReadData()
        {
            return _reader.ReadText();
        }
    }
}
