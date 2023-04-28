using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(4, "Four");
            ht.Add(1, "One");
            ht.Add(3, "Three");
            ht.Add(2, "Two");
            ht.Add(5, "Five");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}