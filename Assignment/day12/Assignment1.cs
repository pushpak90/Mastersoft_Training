using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace dat12_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of stack : ");
            int n = int.Parse(Console.ReadLine());

            Stack s1 = new Stack(n);
            //Store data 
            Console.WriteLine("Enter " + n + " elements : ");
            for(int i = 0; i < n; i++)
            {
                s1.Push(Console.ReadLine());
            }

            //Remove data
            Console.WriteLine("How many number want to remove : ");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0;i < a; i++)
            {
                s1.Pop();
            }

            Console.WriteLine("Reamining Stack : ");
            foreach(var b in s1)
            {
                Console.WriteLine(b);
            }

            Console.ReadKey();
        }
    }
}
