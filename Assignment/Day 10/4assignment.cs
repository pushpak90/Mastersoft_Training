using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_Assignment
{
    
    class College
    {
        public int p_col_id;
        public string p_name, p_principal, p_city, p_state;
        public void input(int c_col_id, string c_name, string c_principal, string c_city, string c_state)
        {
            p_col_id = c_col_id;
            p_name = c_name;
            p_principal = c_principal;
            p_city = c_city;
            p_state = c_state;
        }
    }
    class student : College
    {
        public int p_roll, p_m1, p_m2, p_m3, p_m4, p_m5, p_total;
        public string p_name1, p_branch, p_sub;
        public void data_input(int s_roll, string s_name, string s_branch, string s_sub, int s_m1, int s_m2, int s_m3, int s_m4, int s_m5)
        {
            p_roll = s_roll;
            p_name1 = s_name;
            p_branch = s_branch;
            p_sub = s_branch;
            p_m1 = s_m1;
            p_m2 = s_m2;
            p_m3 = s_m3;
            p_m4 = s_m4;
            p_m5 = s_m5;
            p_total = s_m1 + s_m2 + s_m3 + s_m4 + s_m5;
        }
    }
    class admission : student 
    {
        public void display()
        {
            Console.WriteLine("\nCollege ID : " + p_col_id +
                    "\nName : " + p_name +
                    "\nPrincipal Name : " + p_principal +
                    "\nCity : " + p_city +
                    "\nState : " + p_state+
                    "\nRoll No : "+p_roll+
                    "\nName  : "+p_name1+
                    "\nBranch : "+p_branch+
                    "\nSubject : "+p_branch+
                    "\nMark 1 : " + p_m1 +
                    "\nMark 2 : " + p_m2 +
                    "\nMark 3 : " + p_m3 +
                    "\nMark 4 : " + p_m4 +
                    "\nMark 5 : " + p_m5 
                );
            if(p_total > 250)
            {
                Console.WriteLine("Grade A");
            }
            else if(p_total > 150 && p_total < 250)
            {
                Console.WriteLine("Grade B");
            }
            else if (p_total > 100 && p_total < 150)
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
            admission a1 = new admission();
            Console.Write("Enter College ID : ");
            int Col_id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Principal Name : ");
            string principal = Console.ReadLine();
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.Write("Enter State : ");
            string state = Console.ReadLine();

            Console.Write("Enter Roll No : ");
            int roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            string name1 = Console.ReadLine();
            Console.Write("Enter Branch : ");
            string brach = Console.ReadLine();
            Console.Write("Enter Subject : ");
            string sub = Console.ReadLine();
            Console.Write("Enter mark 1 : ");
            int mark1 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark 2 : ");
            int mark2 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark 3 : ");
            int mark3 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark4 : ");
            int mark4 = int.Parse(Console.ReadLine());
            Console.Write("Enter mark 5 : ");
            int mark5 = int.Parse(Console.ReadLine());

            a1.input(Col_id, name, principal, city, state);
            a1.data_input(roll_no, name1, brach, sub, mark1, mark2, mark3, mark4, mark5);
            a1.display();

            Console.ReadKey();
        }
    }
}
