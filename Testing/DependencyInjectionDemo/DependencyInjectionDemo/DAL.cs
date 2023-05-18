using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class DAL : IDAL
    {
        public string GetData()
        {
            return "Data Accessed Successfully";
        }
    }
}
