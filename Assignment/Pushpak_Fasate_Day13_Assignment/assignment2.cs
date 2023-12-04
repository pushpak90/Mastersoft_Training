using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_13
{
    interface Student
    {
        void input(int s_roll, string s_name, string s_city, int s_age, int s_per);
    }
    
    interface result
    {
        void display();
    }

    class info : Student, result
    {
        int g_roll, g_age, g_per;
        string g_name, g_city;
        public void input(int s_roll, string s_name, string s_city, int s_age, int s_per)
        {
            g_roll = s_roll;
            g_name = s_name;
            g_city = s_city;
            g_age = s_age;
            g_per = s_per;
        }

        public void display()
        {
            Console.WriteLine(
                    "\nRoll No. : "+g_roll+
                    "\nName : "+g_name+
                    "\nCity : "+g_city+
                    "\nAge : "+g_age+
                    "\nPercent : "+g_per
                );
            if( g_per > 60)
            {
                Console.WriteLine("Grade A");
            }
            else if( g_per > 50 && g_per < 60)
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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Roll No. : ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Percent : ");
            int per = int.Parse(Console.ReadLine());

            info s1 = new info();
            s1.input(roll, name, city, age, per);
            s1.display();

            Console.ReadKey();
        }
    }
}
