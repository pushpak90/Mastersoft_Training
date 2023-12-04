using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_13
{
    class A
    {
        public virtual void display(int a_age)
        {
            Console.WriteLine("Age : "+a_age);
        }
    }
    class B : A
    {
        public override void display(int b_name) 
        { 
            Console.WriteLine("Roll No. : "+b_name);
        }
    }
    class C : A
    {
        public override void display(int c_per)
        {
            Console.WriteLine("Percent : "+c_per);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Roll No. : ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("Enter Percent : ");
             int per = int.Parse(Console.ReadLine());

            A a1 = new A();
            A a2 = new B();
            A a3 = new C();
            Console.WriteLine();
            a1.display(age);
            a2.display(roll);
            a3.display(per);
            
            Console.ReadKey();
        }
    }
}
