using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choise \n1.Add \n2.Subtraction \n3.multiplication \nChoise : ");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            switch(ch)
            {
                case 1 :
                    Console.WriteLine("Sum =  "+(num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Sub = "+(num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multi = "+(num1 * num2));
                    break;
            }

            //Hold Outen
            Console.ReadKey();
        }
    }
}