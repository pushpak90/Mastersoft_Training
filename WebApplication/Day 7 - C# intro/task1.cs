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
            string name, city, state, mobile, college, subject;
            int m1, m2, m3, m4, m5, total;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter City : ");
            city = Console.ReadLine();
            Console.Write("Enter State : ");
            state = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            mobile = Console.ReadLine();
            Console.Write("Enter College: ");
            college = Console.ReadLine();
            Console.Write("Enter Subject : ");
            subject = Console.ReadLine();

            Console.Write("Enter mark 1 : ");
            m1 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark 2 : ");
            m2 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark 3 : ");
            m3 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark 4 : ");
            m4 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark 5 : ");
            m5 = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "\n\n\nName : "+name+
                "\nCity : "+city+
                "\nState : "+state+
                "\nMobile : "+mobile+
                "\nCollege : "+college+
                "\nSubject : "+subject
            );
               
            if(m1 > 40 && m2 > 40 && m3 > 40 && m4 > 40 && m5 > 40)
            {
                total = m1 + m2 + m3 + m4 + m5;
                Console.WriteLine("Total Marks : " + total);
                if ( total > 250)
                {
                    Console.WriteLine("Grade A");
                }
                else if (total > 150 && total < 250)
                {
                    Console.WriteLine("Grade B");
                }
                else if (total > 150)
                {
                    Console.WriteLine("Grade A");
                }
                else if (total > 100 && total < 150)
                {
                    Console.WriteLine("Grade C");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            else
            {
                Console.WriteLine("fail");
            }

            //Hold Outen
            Console.ReadKey();
            
        }
    }
}