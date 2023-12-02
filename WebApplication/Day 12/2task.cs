using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack_day12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements : ");
            int n = int.Parse(Console.ReadLine());
            Stack s1 = new Stack(n);
            //insert element in a stack
           
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter elements : " + i+" : ");
                s1.Push(Console.ReadLine());
            }

            Console.Write("Number of elements is to delete : ");
            int d = int.Parse(Console.ReadLine());

            for(int k = 0; k < d; k++)
            {
                s1.Pop();
            }

            foreach(var a in s1)
            {
                Console.Write(a+"\t");
            }

            Console.ReadKey();
        }
    }
}
