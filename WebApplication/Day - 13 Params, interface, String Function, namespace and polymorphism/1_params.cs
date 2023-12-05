using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class Program
    {
        public void display(params int[] val)
        {
            Console.WriteLine("Given Array : ");
            for(int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            //How to pass data value in function parameters.
            
            Console.Write("Enter length array : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter " + n + " elements : ");
            int[] arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            p1.display(arr);
            Console.ReadKey();
        }
    }
}
