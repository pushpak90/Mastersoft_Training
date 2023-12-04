using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    namespace Student
    {
        class admission
        {
            public string gname, gcity;
            public int gage, gper;
            public void input(string name, string city, int age, int per)
            {
                gname = name;
                gcity = city;
                gage = age;
                gper = per;
            }
        }
    }
    namespace College
    {
        class Result : Student.admission
        {
            public void grade()
            {
                Console.WriteLine("\nName : " + gname +
                    "\nCity : " + gcity +
                    "\nAge : " + gage +
                    "\nPercent : " + gper
                    );
                if(gper > 60)
                {
                    Console.WriteLine("Grade A ");
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
            Console.Write("Name : ");
            string i_name = Console.ReadLine();
            Console.Write("City : ");
            string i_city = Console.ReadLine();
            Console.Write("Enter Age : ");
            int i_age = int.Parse(Console.ReadLine());
            Console.Write("Enter Percent : ");
            int i_per = int.Parse(Console.ReadLine());


            College.Result c1 = new College.Result();
            c1.input(i_name, i_city, i_age, i_per);
            c1.grade();

            Console.ReadKey();
        }
    }
}
