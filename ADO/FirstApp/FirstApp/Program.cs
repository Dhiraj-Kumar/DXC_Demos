using System.Data.SqlClient;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=DHIRAJ-PC\\SQLEXPRESS; database=TestDB; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into Customers values(@id, @name, @email, @city, @age)", con);
            Console.WriteLine("Enter CustomerId: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Customer Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Customer City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Customer Age: ");
            int age = Convert.ToInt16(Console.ReadLine());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record saved successfully");
            con.Close();
        }
    }
}
