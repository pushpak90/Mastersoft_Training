using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public string Show(string name)
        {
            Console.WriteLine("Inside the program : ");
            return name;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            string message =  program.Show("Hello World");
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}