using System.Data;
using System.Data.SqlClient;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=DHIRAJ-PC\\SQLEXPRESS; database=TestDB; Integrated Security=true");
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Products", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            ds.Tables[0].Rows[1].Delete();

            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            adp.Update(ds);
            Console.WriteLine("Database Updated");
        }
    }
}