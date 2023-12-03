using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace testday12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Repersentation : ");
            Console.Write("Enter number of elemets : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter " + n + " Elements : ");
            Stack s1 = new Stack(n);
            for(int i = 0; i < n; i++)
            {
                s1.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Given Array : \t");
            foreach(var a in s1)
            {
                Console.Write(a + "\t");
            }
            Console.Write("\n");

            Console.Write("Enter number of elements to remove : ");
            int n1 = int.Parse(Console.ReadLine());
            for(int i = 0; i < n1; i++)
            {
                s1.Pop();
            }

            Console.WriteLine("After Removing elements : ");
            foreach(var i in s1)
            {
                Console.Write(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
