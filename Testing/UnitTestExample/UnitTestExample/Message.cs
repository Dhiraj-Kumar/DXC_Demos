using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Message
    {
        public string SayHello(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Please mention user name");
            }
            return $"Hello {name}";
        }
    }
}
