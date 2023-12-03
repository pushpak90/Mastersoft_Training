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
            Console.Write("Enter number of elements : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + n + " elements : ");
            int[] arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Given array : ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();

            Console.WriteLine("Display using foreach : ");
            foreach(var i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
