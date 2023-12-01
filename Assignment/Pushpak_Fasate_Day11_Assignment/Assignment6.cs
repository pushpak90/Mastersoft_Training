using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day_11_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements : ");
            int n = int.Parse(Console.ReadLine());
            ArrayList arr = new ArrayList(n);
            Console.WriteLine("Enter " + n + " elements : ");
            for(int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine());
            }

            Console.WriteLine("Enter the choice \n1.Count\n2.Sort\n3.Display\n4.Remove(using digit)\n5.Remove(using index)");
            int ch = int.Parse(Console.ReadLine());
            
            switch(ch)
            {
                case 1 :
                    Console.WriteLine("Count : "+arr.Count);
                    break;
                case 2 :
                    Console.WriteLine("Sorted Array ; ");
                    arr.Sort();
                    foreach(var i in arr)
                    {
                        Console.Write(i + "\t");
                    }
                    break;
                case 3 :
                    Console.WriteLine("Display Array : ");
                    foreach(var i in arr)
                    {
                        Console.Write(i + "\t");
                    }
                    break;
                case 4 :
                    Console.WriteLine("Remove value by digit : ");
                    Console.Write("Enter the digit : ");
                    int temp = int.Parse(Console.ReadLine());
                    arr.Remove(temp);
                    foreach(var i in arr)
                    {
                        Console.Write(i + "\t");
                    }
                    break;
                case 5:
                    Console.WriteLine("Remove value by digit : ");
                    Console.Write("Enter the digit : ");
                    int temp1 = int.Parse(Console.ReadLine());
                    arr.RemoveAt(temp1);
                    foreach (var i in arr)
                    {
                        Console.Write(i + "\t");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadKey();
        }
    }
}
