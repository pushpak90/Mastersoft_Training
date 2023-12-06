using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_try_catch_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0, c;
            //comment exception handling
            try
            {
                c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
