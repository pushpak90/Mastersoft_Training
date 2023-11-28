using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Show()
        {
            Console.WriteLine("This is function 1 : No Parameter");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Show();
            Console.ReadKey();
        }
    }
}