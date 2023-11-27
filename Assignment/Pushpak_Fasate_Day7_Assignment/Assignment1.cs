using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            //Table using for loop
            Console.WriteLine("Using for loop : ");
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine(n+" * "+j+" = "+(n*j));
            }
            //table using while loop
            int i = 1;
            Console.WriteLine("\nUsing while loop : ");
            while (i <= 10)
            {
                Console.WriteLine(n + " * " + i + " = " + (n * i));
                i++;
            }
            //Table using do while loop
            Console.WriteLine("\nUsing do while loop : ");
            int k = 1;
            do
            {
                Console.WriteLine(n + " * " + k + " = " + (n * k));
                k++;
            } while (k <= 10);

            //Hold Outen
            Console.ReadKey();
            
        }
    }
}