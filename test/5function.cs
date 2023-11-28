using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Sum(int n1, int n2)
        {
            return n1+n2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Num 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}