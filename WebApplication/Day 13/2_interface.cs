using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    interface student
    {
        void display(int a, int b);
    }
    interface result
    {
        void show();
    }
     class A : result , student  //access interface
    {
        public void display(int a, int b)
        {
            Console.WriteLine("a : "+a+"\nb : "+b);
        }
        public void show()
        {
            Console.WriteLine("This is result interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.Write("Enter a : ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            int a2 = int.Parse(Console.ReadLine());

            a.display(a1, a2);
            a.show();
            Console.ReadKey();
        }
    }
}
