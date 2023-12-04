using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_13
{
    namespace Student
    {
        class admission
        {
            public int g_age, g_per;
            public string g_name, g_city;
            public void input(string i_name, string i_city, int age, int per)
            {
                g_name = i_name;
                g_city = i_city;
                g_age = age;
                g_per = per;
            }
        }
    }
    namespace College
    {
        class result : Student.admission
        {
            public void grade()
            {
                Console.WriteLine("\nName : " + g_name +
                    "\nCity : " + g_city +
                    "\nAge : " + g_age +
                    "\nPercent : " + g_per);
                if(g_per > 60)
                {
                    Console.WriteLine("Grade A");
                }
                else if(g_per > 50 && g_per < 60)
                {
                    Console.WriteLine("Grade B");
                }
                else if(g_per > 40 && g_per < 50)
                {
                    Console.WriteLine("Grade C");
                }
                else
                {
                    Console.WriteLine("Fail");
                }

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter City : "); ;
            string city = Console.ReadLine();
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Percent : ");
            int per = int.Parse(Console.ReadLine());

            College.result c1 = new College.result();
            c1.input(name, city, age, per);
            c1.grade();

            Console.ReadKey();
        }
    }
}
