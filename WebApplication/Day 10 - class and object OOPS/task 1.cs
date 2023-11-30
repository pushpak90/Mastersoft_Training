using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class student
    {
        int groll, gper, gtot;
        string gname, gcity, gbranch;
        public void input(int nroll, string nname , string ncity, string nbranch, int ntotal, int npercent)
        {
            groll = nroll;
            gname = nname;
            gcity = ncity;
            gbranch = nbranch;
            gtot = ntotal;
            gper = npercent;
            display();
        }

        public void display()
        {
            if(gper > 60 && gbranch == "CSE" && gtot > 150)
            {
                Console.WriteLine("\nRoll " + groll +
                            "\nName : "+gname+
                            "\nCity : "+gcity+
                            "\nBranch : "+gbranch+
                            "\nTotal : "+gtot+
                            "\nPercent : "+gper
                    );
            }
            else
            {
                Console.WriteLine("Re-addmission");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Roll : ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Name  : ");
            string name = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Total : ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("Percent : ");
            int per = int.Parse(Console.ReadLine());

            student p1 = new student();
            p1.input(roll, name, city, branch, total, per);
            
            Console.ReadLine();
        }
    }
}
