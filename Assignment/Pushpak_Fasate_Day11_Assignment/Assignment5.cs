using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Assignment
{
    class Program
    {
        struct student
        {
            public int roll;
            public string name;
            public string city;
            public string branch;
            public int per;
        };
        class College
        {
            public void input(int i_roll, string i_name, string i_city, string i_branch, int i_per)
            {
                Console.WriteLine("\n---------------------------------\nRoll No. : " + i_roll +
                        "\nName : "+i_name+
                        "\nCity : "+i_city+
                        "\nBranch : "+i_branch+
                        "\nPercentage : "+i_per
                    );
                if(i_per >= 60)
                {
                    Console.WriteLine("Grade A");
                }
                else if(i_per >= 50 && i_per <=60)
                {
                    Console.WriteLine("Grade B");
                }
                else if(i_per >= 40 && i_per <=50 )
                {
                    Console.WriteLine("Grade C");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
        }
        static void Main(string[] args)
        {
            student s1;
            Console.Write("Enter Roll No. : ");
            s1.roll = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            s1.name = Console.ReadLine();
            Console.Write("Enter City : ");
            s1.city = Console.ReadLine();
            Console.Write("Enter Branch : ");
            s1.branch = Console.ReadLine();
            Console.Write("Enter Percentage : ");
            s1.per = int.Parse(Console.ReadLine());

            College c1 = new College();
            c1.input(i_roll : s1.roll, i_name : s1.name, i_city : s1.city, i_branch : s1.branch, i_per :  s1.per); 

            Console.ReadKey();
        }
    }
}
