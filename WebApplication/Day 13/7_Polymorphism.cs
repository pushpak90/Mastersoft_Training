using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("This is first class");
        }
    }
    class B : A
    {
        public override void display()
        {
            Console.WriteLine("This is drived class ");
        }
    }
    class  C : A
    {
        public override void display()
        {
            Console.WriteLine("This is another drived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new B();
            A a3 = new C();

            a1.display();
            a2.display();
            a3.display();
            Console.ReadKey();
        }
    }
}
