using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter " + n + " elements : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum : " + arr.Sum());

            Console.WriteLine("Min : " + arr.Min());

            Console.WriteLine("Max : " + arr.Max());

            Console.Write("Sorted Array : ");
            Array.Sort(arr);
            foreach(int i in arr)
            {
                Console.Write(i+"\t");
            }

            

            Console.ReadKey();
        }
    }
}
