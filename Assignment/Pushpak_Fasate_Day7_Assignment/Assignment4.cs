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
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("State : ");
            string state = Console.ReadLine();
            Console.Write("Mobile : ");
            string mobile = Console.ReadLine();
            Console.Write("College : ");
            string college = Console.ReadLine();
            Console.Write("Subject : ");
            string subject = Console.ReadLine();
            Console.Write("Mark 1 : ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Mark 2 : ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Mark 3 : ");
            int m3 = int.Parse(Console.ReadLine());
            Console.Write("Mark 4 : ");
            int m4 = int.Parse(Console.ReadLine());
            Console.Write("Mark 5 : ");
            int m5 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            if(m1 >= 40 && m2 >= 40 && m3 >= 40 && m4 >= 40 && m5 >= 40)
            {
                int total_mark = m1 + m2 + m3 + m4 + m5;
                Console.WriteLine("Total : " + total_mark);
                if(total_mark >= 250)
                {
                    Console.WriteLine("Grade A");
                }
                else if(total_mark > 150 && total_mark < 250)
                {
                    Console.WriteLine("Grade B");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.WriteLine("\nName : " +name+
                "\nCity : " +city+
                "\nState : " +state+
                "\nMobile : " +mobile+
                "\nCollege " +college+
                "\nSubject : "+subject);

            //Hold Output
            Console.ReadKey();
        }
    }
}