using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your choice : \n1.Min \n2.Max \n3.SQRT \n4.ABS \n5.Round\n");
            int ch = int.Parse(Console.ReadLine());
            Console.Write("Enter Num 1 : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Num 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            switch(ch)
            {
                case 1 :
                    Console.Write("Min : " + Math.Min(num1, num2));
                    break;
                case 2:
                    Console.Write("Min : " + Math.Max(num1, num2));
                    break;
                case 3:
                    Console.Write("Sqare : " + Math.Sqrt(num1));
                    break;
                case 4:
                    Console.Write("ABS : " + Math.Abs(num1));
                    break;
                case 5:
                    Console.Write("Round : " + Math.Round(num1));
                    break;
            }
            Console.ReadKey();
        }
    }
}
