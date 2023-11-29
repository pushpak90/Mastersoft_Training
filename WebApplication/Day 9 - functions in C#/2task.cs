using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        //Crate a function 
        void input(string n, string c, int a, int m1, int m2, int m3, int m4, int m5)
        {
            int total = m1 + m2 + m3 + m4 + m5;

            Console.WriteLine("\nName : " + n +
                "\nCity : " + c+
                "\nTotal : " +total);
            if(total > 250 && a > 15)
            {
                Console.WriteLine("Grade A");
            }
            else if(total > 150 && a > 18 && a < 25 && total < 250)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 1 : ");
            int mark1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 2 : ");
            int mark2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 3 : ");
            int mark3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 4 : ");
            int mark4 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark 5 : ");
            int mark5 = int.Parse(Console.ReadLine());

            p1.input(name, city, age, mark1, mark2, mark3, mark4, mark5);


            Console.ReadKey();
        }
    }
}
