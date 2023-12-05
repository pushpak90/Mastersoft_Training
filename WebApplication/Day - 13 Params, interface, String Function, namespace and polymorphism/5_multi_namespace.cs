using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    namespace Student
    {
        class Admission
        {
            public void display()
            {
                Console.WriteLine("This is display function using namespace");
            }
        }

        class Result
        {
            public void show()
            {
                Console.WriteLine("This show function using namespace");
            }
        }
    }
    namespace employee
    {
        class Salary
        {
            public void print()
            {
                Console.WriteLine("This is employee Salary");
            }
            public void pf()
            {
                Console.WriteLine("This is employee PF");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student.Admission s1 = new Student.Admission();
            Student.Result s2 = new Student.Result();
            s1.display();
            s2.show();
            employee.Salary e1 = new employee.Salary();

            e1.print();
            
            Console.ReadKey();
        }
    }
}
