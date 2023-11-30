using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web
{
    class Program
    {
        string gname, gcol, gbranch, gsubject;
        int gper;
        void input(string nname, string ncol,string nsubject, string nbranch, int npercent)
        {
            gname = nname;
            gcol = ncol;
            gsubject = nsubject;
            gbranch = nbranch;
            gper = npercent;
            grade();
            display();
        }
        void grade()
        {
            Console.WriteLine("\n---------------------------------------");
            if(gper >= 60)
            {
                Console.WriteLine("Grade A");
            }
            else if(gper >= 50 && gper <= 60)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        void display()
        {
            Console.Write(
                "\nName : "+gname+
                "\nCollege : "+gcol+
                "\nSubject : "+gsubject+
                "\nBranch : "+gbranch+
                "\nPercentage : "+gper
                );
        }
        static void Main(string[] args)
        {
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("College : ");
            string college = Console.ReadLine();
            Console.Write("Subject : ");
            string subject = Console.ReadLine();
            Console.Write("Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Percentage : ");
            int percent = int.Parse(Console.ReadLine());

            Program p1 = new Program();
            p1.input(name, college, subject, branch, percent);

            Console.ReadKey();
        }
    }
}
