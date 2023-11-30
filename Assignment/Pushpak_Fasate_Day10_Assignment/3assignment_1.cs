using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_Assignment
{
    class b_info
    {
        public void basicinfo(string b_name, string b_city, string b_email, string b_mobile, string b_state, string b_country)
        {
            Console.WriteLine("\nName : " + b_name +
                "\nCity : " + b_city +
                "\nEmail : " + b_email +
                "\nMobile No : " + b_mobile +
                "\nState : " + b_state +
                "\nCountry : " + b_country
                );
        }
    }
    class qualification
    {
        public void quali(string q_col, string q_sem, string q_branch, string q_address)
        {
            Console.WriteLine("\nCollege : " + q_col+
                "\nSem : " + q_sem +
                "\nBranch : " + q_branch +
                "\nAddress : " + q_address
                );
        }
    }
    class exprence
    {
        public void exp(string e_comp, string e_dest, string e_sal, string e_joining)
        {
            Console.WriteLine("\nCompnay : " + e_comp +
                "\nDesignation : " + e_dest+
                "\nSalary : " + e_sal +
                "\nJoining : " + e_joining
                );
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
            Console.Write("Enter Email : ");
            string email = Console.ReadLine();
            Console.Write("Enter Mobile No. : ");
            string mobile = Console.ReadLine();
            Console.Write("Enter State : ");
            string state = Console.ReadLine();
            Console.Write("Enter Country : ");
            string country = Console.ReadLine();

            Console.Write("Enter College : ");
            string college = Console.ReadLine();
            Console.Write("Enter Sem : ");
            string sem = Console.ReadLine();
            Console.Write("Enter Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();

            Console.Write("Enter Compnay : ");
            string comp = Console.ReadLine();
            Console.Write("Enter Designation : ");
            string dest = Console.ReadLine();
            Console.Write("Enter Salary : ");
            string salary = Console.ReadLine();
            Console.Write("Enter Joining : ");
            string joining = Console.ReadLine();

            b_info b = new b_info();
            b.basicinfo(name, city, email, mobile, state, country);

            qualification q = new qualification();
            q.quali(college, dest, salary, joining);

            exprence e = new exprence();
            e.exp(comp, dest, salary, joining);
            Console.ReadKey();
        }
    }
}
