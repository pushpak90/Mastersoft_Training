using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_Assignment
{
    sealed class compnay
    {
        public int g_salary;
        public void salary(int n_sal)
        {
            g_salary = n_sal;
        }
    }
    class employee 
    {
        
        public void performance(int g_salary)
        {
            if(g_salary > 3000)
            {
                Console.WriteLine("Grade A");
            }
            else if(g_salary > 2000 && g_salary < 3000)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("New Joining");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Salary : ");
            int sal = int.Parse(Console.ReadLine());

            employee e1 = new employee();
            compnay c1 = new compnay();
            c1.salary(sal);
            e1.performance(sal);

            Console.ReadKey();
        }
    }
}
