using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Sum(int a, int b)
        {
            int total = a + b;
            Console.WriteLine("Sum : "+total);
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            Console.Write("Enter num 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter name  2 : ");
            int num2 = int.Parse(Console.ReadLine());
            test.Sum(num1, num2);
            
            Console.ReadKey();
        }
    }
}