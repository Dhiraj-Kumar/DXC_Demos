using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookRepository : IBookRepository
    {
        SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS; Database=TestDB; Integrated Security=true");
        public int AddBook(string name, string author, int price)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Books values (@BookName, @Author, @Price)", con);
            cmd.Parameters.AddWithValue("@BookName", name);
            cmd.Parameters.AddWithValue("@Author", author);
            cmd.Parameters.AddWithValue("@Price", price);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
