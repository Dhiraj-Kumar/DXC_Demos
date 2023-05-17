using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class App
    {
        List<Customer> list;
        public App()
        {
            list = new List<Customer>();
        }

        public bool AddCustomer(Customer customer)
        {
            list.Add(customer);
            return true;
        }

        public bool RemoveCustomer(int id)
        {
            return list.Remove(list.Find(x => x.CustomerId == id));
            
        }

        public List<Customer> GetAllCustomers() 
        { 
            return list;
        }

        public Customer GetCustomer(int id)
        {
            return list.Find(x => x.CustomerId == id);
        }
    }
}
