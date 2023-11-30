using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_Assignment
{
    class info
    {
        public string g_name, g_sub, g_col, g_branch;
        public void input(string i_name, string i_col, string i_sub, string i_branch)
        {
            g_name = i_name;
            g_sub = i_sub;
            g_col = i_col;
            g_branch = i_branch;
        }
        
    }

    class grade : info
    {
        public int g_per;
        public void cal_grade(int c_per)
        {
            Console.WriteLine();
            g_per = c_per;
            if (c_per > 60)
            {
                Console.WriteLine("Grade A");
            }
            else if(c_per > 50 && c_per < 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (c_per > 40 && c_per < 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            
        }
    }
    class outinfo : grade
    {
        public void display()
        {
            Console.WriteLine("\n\nName : " + g_name +
                "\nCollege : " + g_col +
                "\nSubject : " + g_sub +
                "\nBranch : " + g_branch +
                "\nPercentage : " + g_per
                );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter College : ");
            string college = Console.ReadLine();
            Console.Write("Enter Subject : ");
            string sub = Console.ReadLine();
            Console.Write("Enter Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Enter Percentage : ");
            int percent = int.Parse(Console.ReadLine());

            outinfo o1 = new outinfo();
            o1.input(name, college, sub, branch);
            o1.cal_grade(percent);
            o1.display();

            Console.ReadKey();
        }
    }
}
