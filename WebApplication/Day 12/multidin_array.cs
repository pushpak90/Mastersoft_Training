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
            Console.Write("Enter number of rows : ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter number of Col : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + r + " and "+ c + " elements : ");
            int[,] arr = new int[r,c];
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Given Array : ");
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of rows : ");
            for(int i = 0; i < r; i++)
            {
                int sum = 0;
                for(int j = 0; j < c; j++)
                {
                    sum = sum + arr[i, j];
                    Console.Write(arr[i, j] + "\t\t");
                }
                Console.WriteLine("sum = " + sum);
            }
            
            for(int j = 0; j < c; j++)
            {
                int sum = 0;
                for(int i = 0; i < r; i++)
                {
                    sum = sum + arr[i, j];
                }
                Console.Write("Sum : " + sum+"\t");
            }

            Console.ReadKey();
        }
    }
}
