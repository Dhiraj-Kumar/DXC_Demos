using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class DAL2 : IDAL
    {
        public string GetData()
        {
            return "Data with upgraded version";
        }
    }
}
