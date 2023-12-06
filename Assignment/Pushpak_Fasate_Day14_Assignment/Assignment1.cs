using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_14_assignment
{
    class Program
    {
        static int display(int a1, int b1)
        {
            return a1 + b1;
        }
        static string display(string n, string s)
        {
            return n+" "+s;
        }
        static void display(int p)
        {
            Console.WriteLine("Percent : " + p);
            if(p > 60)
            {
                Console.WriteLine("Grade A");
            }
            else if (p > 50 && p < 60)
            {
                Console.WriteLine("Grade B");
            }
            else if(p > 40 &&  p < 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Surname : ");
            string s_name = Console.ReadLine();
            Console.Write("Enter A : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter Percent : ");
            int per = int.Parse(Console.ReadLine());
            
            string full_name = display(name, s_name);
            Console.WriteLine("\n\nFull Name : " + full_name);

            int sum = display(a, b);
            Console.WriteLine("Sum : " + sum);

            display(per);

            Console.ReadKey();
        }
    }
}
