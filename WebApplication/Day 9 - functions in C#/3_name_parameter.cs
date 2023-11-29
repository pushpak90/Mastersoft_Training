using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_error
{
    class Program
    {
        void input(int roll, string city)
        {
            Console.WriteLine(roll + "\n" + city);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();

            p1.input(city : "Nagpur", roll : 30);

            Console.ReadLine();
        }
    }
}
