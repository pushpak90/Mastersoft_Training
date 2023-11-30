using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_Assignment
{
    class info
    {
        public string g_name, g_city, g_col, g_branch;
        public int g_per;
        public void input(string i_name, string i_city, string i_col, string i_branch, int i_per)
        {
            g_name = i_name;
            g_city = i_city;
            g_col = i_col;
            g_branch = i_branch;
            g_per = i_per;
        }
    }

    class grade : info
    {
        public void display()
        {
            Console.WriteLine("\n\nName : " + g_name +
                "\nCity : " + g_city +
                "\nCollege : " + g_col +
                "\nBranch : " + g_branch +
                "\nPercentage : " + g_per
                );
            if (g_per > 60)
            {
                Console.WriteLine("Grade A");
            }
            else if(g_per > 50 && g_per < 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (g_per > 40 && g_per < 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.Write("Enter College : ");
            string college = Console.ReadLine();
            Console.Write("Enter Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Enter Percentage : ");
            int percent = int.Parse(Console.ReadLine());

            grade g = new grade();
            g.input(name, city, college, branch, percent);
            g.display();

            Console.ReadKey();
        }
    }
}
