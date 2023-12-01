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
            Console.Write("Enter the number of rows : ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of Coloums : ");
            int c = int.Parse(Console.ReadLine());

            int[,] arr = new int[r, c];
            Console.WriteLine("Enter " + r + " and " + c+" elements : ");
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Given Array : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + "\t");       
                }
                Console.WriteLine();
            }

            //Sum of rows
            Console.WriteLine("\nPerforming operations : ");
            for (int i = 0; i < r; i++)
            {
                int sumr = 0;
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    sumr = sumr + arr[i, j];
                }
                Console.Write("Sum of rows " + i + " : " + sumr);
                Console.WriteLine();
            }
            //Sum of coloums
            Console.WriteLine();
            for (int j = 0; j < c; j++)
            {
                int sumc = 0;
                for (int i = 0; i < r; i++)
                {
                    sumc = sumc + arr[i, j];
                }
                Console.WriteLine("Sum of rows " + j + " : " + sumc);
            }

            //Even
            Console.Write("\nEven Number : \n");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(arr[i, j]%2 == 0)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                }
            }

            //Odd 
            Console.Write("\nOdd Number : \n");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (arr[i, j] % 2 != 0)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
