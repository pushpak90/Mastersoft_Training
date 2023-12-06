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
            int a = 10, b = 0;
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            //comment exception handling
            try
            {
                Console.WriteLine(arr[1]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("This array program");
            }
            Console.ReadKey();
        }
    }
}
