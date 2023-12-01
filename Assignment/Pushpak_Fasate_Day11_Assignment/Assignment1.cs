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
            int sum = 0, greater = 0, smaller;
            Console.Write("Enter number of elements : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter " + n + " elements : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i< arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.Write("Sum : \t" + sum+"\n");
            Console.Write("Even : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]%2 == 0)
                {
                    Console.Write(arr[i] + "\t");
                }
            }

            Console.Write("\nOdd : \t");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + "\t");
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (greater < arr[i])
                {
                    greater = arr[i];
                }
            }
            Console.WriteLine("\nGreate Number : "+greater);
            smaller = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (smaller > arr[i])
                {
                    smaller = arr[i];
                }
            }
            Console.WriteLine("Smaller Number : " + smaller);

            Console.ReadKey();
        }
    }
}
