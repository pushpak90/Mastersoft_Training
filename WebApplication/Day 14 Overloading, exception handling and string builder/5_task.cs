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
        public int Display(int m1, int m2, int m3, int m4, int m5)
        {   
            int (m1 > 40 &&)
            return m1 + m2 + m3 + m4 + m5;
        }
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            Console.Write("Enter Mark 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 3 : ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 4 : ");
            num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 5 : ");
            num5 = int.Parse(Console.ReadLine());

            
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
