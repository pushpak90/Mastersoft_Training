using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web
{
    class Program
    {
        int per;
        void basic_info(string nname, string ncity, string ncol, string nbranch, int npercent)
        {
            Console.WriteLine("------------------------------------\nName : "+ nname+
                "\nCity : "+ncity+
                "\nCollege : "+ncol+
                "\nBranch : "+nbranch+
                "\nPercent : "+npercent
                );
            per = npercent;
            grade(per);
        }
        void grade(int per)
        {
            if(per >= 60)
            {
                Console.WriteLine("Grade A");
            }
            else if(per >= 50 && per <= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if(per >= 40 && per <= 50)
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
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("College : ");
            string col = Console.ReadLine();
            Console.Write("Branch : ");
            string branch = Console.ReadLine();
            Console.Write("Percent : ");
            int percent = int.Parse(Console.ReadLine());



            p1.basic_info(name, city, col, branch, percent);
            

            Console.ReadKey();
        }
    }
}
