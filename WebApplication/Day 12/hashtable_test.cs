using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace testday12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Repersentation : ");
            Console.Write("Enter number of elemets : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter " + n + " Elements : ");
            Hashtable h1 = new Hashtable(n);
            for(int i = 0; i < n; i++)
            {
                h1.Add(int.Parse(Console.ReadLine()),Console.ReadLine());
            }

            Console.WriteLine("Given Array is : ");
            foreach(var i in h1.Keys)
            {
                Console.WriteLine(i + " "+h1[i]);
            }
            Console.ReadKey();
        }
    }
}
