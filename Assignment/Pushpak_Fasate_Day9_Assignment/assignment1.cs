using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web
{
    class Program
    {
        string  gname, gcity, gstate, gcol, gmob, gbranch, gsub;
        int gper, groll;
        void display(int nroll, string nname, string ncity, string nstate, string ncol, string nmob, string nbranch, string nsub)
        {
            groll = nroll;
            gcity = ncity;
            gname = nname;
            gstate = nstate;
            gcol = ncol;
            gmob = nmob;
            gbranch = nbranch;
            gsub = nsub;
            display();
        }
        void display()
        {
            Console.WriteLine("\n------------------------\nRoll Number : " + groll +
                    "\nName : " + gname +
                    "\nCity : " + gcity +
                    "\nState : " + gstate +
                    "\nCollege : " + gcol +
                    "\nMobile : " + gmob +
                    "\nBranch : " + gbranch +
                    "\nSubject : " + gsub
                );
        }
        void grade(int nper)
        {
            if(nper >= 60)
            {
                Console.WriteLine("Grade A");
            }
            else if(nper >= 50 && nper <= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if(nper >= 40 && nper <= 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.Write("Enter Roll No. : ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("State : ");
            string state = Console.ReadLine();
            Console.Write("College : ");
            string college = Console.ReadLine();
            Console.Write("Mobile : ");
            string mobile = Console.ReadLine();
            Console.Write("Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Subject : ");
            string sub = Console.ReadLine();
            Console.Write("Percentage : ");
            int per = int.Parse(Console.ReadLine());

            p1.display(roll, name, city, state, college, mobile, branch, sub);
            p1.grade(per);

            Console.ReadKey();
        }
    }
}
