using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_14
{
    class Program
    {
        static int display(int a, int b)
        {
            return a + b;
        }
        static double display(double x, double y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a :");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter b :");
            int b1 = int.Parse(Console.ReadLine());

            Console.Write("Enter x (double) : ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y (double) : ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            int sum = display(a1, b1);
            Console.WriteLine("Sum : "+sum);

            double mul = display(x1, y1);
            Console.WriteLine("Multi : " + mul);

            Console.ReadLine();
        }
    }
}
