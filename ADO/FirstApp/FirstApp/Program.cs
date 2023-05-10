using System.Data.SqlClient;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=DHIRAJ-PC\\SQLEXPRESS; database=Northwind; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customers", con);
            SqlDataReader dr = cmd.ExecuteReader();
            //Console.WriteLine(dr.FieldCount);
            while (dr.Read())
            {
                //Console.WriteLine($"{dr["CustomerId"]} | {dr["ContactName"]} | {dr["ContactTitle"]} | {dr["Address"]} | {dr["City"]}");
                Console.WriteLine($"{dr[0]} | {dr[1]} | {dr[2]} | {dr[3]} | {dr[4]}");
            }
            con.Close();
        }
    }
}