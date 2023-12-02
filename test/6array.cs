using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 6array
{
    class Program
    {
        static void main(string[], args)
        {
            Console.Write("Enter Length of aaray : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.Write("Enter Array : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Given Array : ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.ReadKey();
        }
    }
}