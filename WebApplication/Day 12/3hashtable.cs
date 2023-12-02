using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hash_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of hashtable : ");
            int n = int.Parse(Console.ReadLine());
            Hashtable h1 = new Hashtable(n);

            Console.WriteLine("Enter key and value : ");
            for(int i = 0; i < n; i++)
            {
                h1.Add(Console.ReadLine(), Console.ReadLine());
            }

            Console.WriteLine("Display Hash Table : ");
            foreach(var i in h1.Keys)
            {
                Console.WriteLine(i+" "+h1[i]);
            }

            Console.ReadLine();
        }
    }
}
