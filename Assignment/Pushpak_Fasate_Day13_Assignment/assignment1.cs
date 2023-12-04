using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_13
{
    class Simple_array
    {
        public void display(params int[] value)
        {
            Console.WriteLine("Given Array : ");
            foreach (int i in value)
            {
                Console.Write(i+"\t");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter "+n+" elements : ");
            for(int i =0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Simple_array s1 = new Simple_array();
            s1.display(arr);

            Console.ReadKey();
        }
    }
}
