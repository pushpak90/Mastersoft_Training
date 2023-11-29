using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web
{
    class Program
    {
        void basic_info(string nname, string ncity, string nemail, string nmobile, string nstate, string ncountry)
        {
            Console.WriteLine("------------------------------------\nName : "+ nname+
                "\nCity : "+ncity+
                "\nEmail : "+nemail+
                "\nMobile : "+nmobile+
                "\nState : "+nstate+
                "\nCountry : "+ncountry);
        }
        void qualification(string col, string sem1, string nbranch, string naddress)
        {
            Console.WriteLine("------------------------------------\nCollege : " + col+
                "\nSem : "+sem1+
                "\nBranch : "+nbranch+
                "\nAddress : "+naddress
                );
        }
        void exprence(string ncomp, string ndest, int sal, string njoining)
        {
            Console.Write("------------------------------------\nCompnay : " + ncomp+
               "\nDest : " + ndest+
               "\nSalary : " + sal+
               "\nJoining : " + njoining
               );
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();
            Console.Write("Mobile : ");
            string mobile = Console.ReadLine();
            Console.Write("State : ");
            string state = Console.ReadLine();
            Console.Write("Country : ");
            string country = Console.ReadLine();

            Console.Write("College : ");
            string college = Console.ReadLine();
            Console.Write("Semi : ");
            string sem = Console.ReadLine();
            Console.Write("Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Address : ");
            string address = Console.ReadLine();

            Console.Write("Compnay : ");
            string comp = Console.ReadLine();
            Console.Write("Dest : ");
            string dest = Console.ReadLine();
            Console.Write("Salary : ");
            int salary = int.Parse(Console.ReadLine());
            Console.Write("Joining : ");
            string joining = Console.ReadLine();

            p1.basic_info(name, city, email, mobile, state, country);
            p1.qualification(college, sem, branch, address);
            p1.exprence(comp, dest, salary, joining);

            Console.ReadKey();
        }
    }
}
