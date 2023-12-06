using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace exception_try_catch_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter Num 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num 2 : ");
            num2 = int.Parse(Console.ReadLine());
            //comment exception handling
            try
            {
                if(num2 == 0)
                {
                    throw new Exception("Number not divisiable by 0");
                }
                num3 = num1 / num2;
                Console.WriteLine("Divisiable : "+num3);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
