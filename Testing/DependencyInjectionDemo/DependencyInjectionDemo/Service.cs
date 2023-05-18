using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class Service
    {
        private IDAL _dal;
        public Service(IDAL dal)
        {
            _dal = dal;
        }
        public void PrintData()
        {
            Console.WriteLine(_dal.GetData());
        }
    }
}
