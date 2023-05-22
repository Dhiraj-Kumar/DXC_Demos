using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface IBookService
    {
        int AddBook(string name, string author, int price);
    }
}
