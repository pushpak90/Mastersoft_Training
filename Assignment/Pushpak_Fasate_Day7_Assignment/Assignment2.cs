using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Orgnization : ");
            string orgnization = Console.ReadLine();
            Console.Write("Enter Dest : ");
            string dest = Console.ReadLine();
            Console.Write("Enter Salary : "); ;
            int salary = int.Parse(Console.ReadLine());
            Console.Write("Enter HRA : ");
            int hra = int.Parse(Console.ReadLine());
            Console.Write("Enter DA : ");
            int da = int.Parse(Console.ReadLine());
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.WriteLine("---------------------------------------");
            int total_salary = salary + hra + da;
            Console.WriteLine("Name : "+name+
                "\nOrignization : "+orgnization+
                "\nDest : "+dest+
                "\nCity : " + city+
                "\nSalary : " +salary+
                "\nHRA : "+hra+
                "\nDA : "+da
                );
            if(total_salary >= 5000)
            {
                Console.WriteLine("5% of "+total_salary+" : "+(5 * total_salary) / 100);
            }
            else if(total_salary >= 2000 && total_salary <= 5000)
            {
                Console.WriteLine("2% of " + total_salary + " : " + (2 * total_salary) / 100);
            }
            else
            {
                Console.WriteLine("Wait for next approval");
            }
            //Hold Outen
            Console.ReadKey();
        }
    }
}