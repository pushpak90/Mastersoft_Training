using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace dat12_Assignment
{
    class  admission 
    {
        int p_m1, p_m2, p_m3, p_m4, p_m5;
        public admission(int coll_id, string p_name, string p_principal, string p_city, string p_state, int p_roll, 
            string p_name1, string p_branch, string p_sub, int m1, int m2, int m3, int m4, int m5)
        {
            Console.Write("\n\n\n\nCollege ID  : " + coll_id +
                    "\nName : " + p_name +
                    "\nPrincipal Name : " + p_principal +
                    "\nCity : " + p_city +
                    "\nState : " + p_state +
                    "\nRoll No. : " + p_roll +
                    "\nName : " + p_name1 +
                    "\nBranch : " + p_branch +
                    "\nSubject : " + p_sub +
                    "\nMark 1 : " + m1 +
                    "\nMark 2 : " + m2 +
                    "\nMark 3 : " + m3 +
                    "\nMark 4 : " + m4 +
                    "\nMark 5 : " + m5 
                );
            p_m1 = m1;
            p_m2 = m2;
            p_m3 = m3;
            p_m4 = m4;
            p_m5 = m5;

        }
        public void grade()
        {
            int total = p_m1 + p_m2 + p_m3 + p_m4 + p_m5;
            if(total > 250)
            {
                Console.Write("\n\nGrade A ");
            }
            else if(total > 150 && total < 250)
            {
                Console.Write("\n\nGrade B ");
            }
            else if(total > 100 && total < 150)
            {
                Console.Write("\n\nGrade C ");
            }
            else
            {
                Console.Write("\n\nFail");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter College ID : ");
            int college_id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Principal Name : ");
            string principal = Console.ReadLine();
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.Write("Enter State : ");
            string state = Console.ReadLine();

            Console.Write("Enter Roll No. : ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            string name1 = Console.ReadLine();
            Console.Write("Enter Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Subject : ");
            string sub = Console.ReadLine();
            Console.Write("Mark 1 : ");
            int mark1 = int.Parse(Console.ReadLine());
            Console.Write("Mark 2 : ");
            int mark2 = int.Parse(Console.ReadLine());
            Console.Write("Mark 3 : ");
            int mark3 = int.Parse(Console.ReadLine());
            Console.Write("Mark 4 : ");
            int mark4 = int.Parse(Console.ReadLine());
            Console.Write("Mark 5 : ");
            int mark5 = int.Parse(Console.ReadLine());

            admission a1 = new admission(college_id, name, principal, city, state, roll, name1, branch, sub, mark1, mark2, mark3, mark4, mark5);
            a1.grade();

            Console.ReadKey();
        }
    }
}
