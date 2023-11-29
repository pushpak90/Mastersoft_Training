using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web
{
    class Program
    {
        int gtotal,  gm1, gm2, gm3, gm4, gm5;
        string gname, gcity, gcol;
        void input(string nname, string ncity, string ncol, int m1, int m2, int m3, int m4, int m5)
        {
            gname = nname;
            gcity = ncity;
            gcol = ncol;
            gm1 = m1;
            gm2 = m2;
            gm3 = m3;
            gm4 = m4;
            gm5 = m5;
            int total = m1 + m2 + m3 + m4 + m5;
            gtotal = total;
            display();
            grade();
        }
        void display()
        {
           Console.WriteLine("\n----------------------------------\nName:"+gname+
                "\nCity : "+gcity+
                "\nCollege : "+gcol+
                "\nMark 1 : " + gm1 +
                "\nMark 2 : " + gm2 +
                "\nMark 3 : " + gm3 +
                "\nMark 4 : " + gm4 +
                "\nMark 5 : " + gm5
              );
        }
        void grade()
        {
            if(gtotal >= 250)
            {
                Console.WriteLine("First Division");
            }
            else if(gtotal > 150 && gtotal < 250)
            {
                Console.WriteLine("Second Division");
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

            p1.input(name, city, col, mark1, mark2, mark3, mark4, mark5);
            

            Console.ReadKey();
        }
    }
}
