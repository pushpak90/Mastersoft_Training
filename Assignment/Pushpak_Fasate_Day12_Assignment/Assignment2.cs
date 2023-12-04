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
            Console.WriteLine("1.ArrayList\n2.Stack\n3.Sorted\n4.Hash Table");
            Console.Write("Enter your choice : ");
            int ch = int.Parse(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    Console.WriteLine("\n\nArray List : ");
                    Console.Write("Enter number of elements : ");
                    int n1 = int.Parse(Console.ReadLine());
                    ArrayList arr = new ArrayList(n1);
                    Console.Write("Enter elements"+n1+" : ");
                    for(int a = 0; a < n1; a++)
                    {
                        arr.Add(Console.ReadLine());
                    }
                    for(int k1 = 0; k1 < 10; k1++)
                    {

                    
                    Console.WriteLine("\n\n1.Count\n2.Sort\n3.Display\n4.Remove(using digit)\n5.Remove(using index)");
                    Console.Write("Enter your choice : ");
                    int ch1 = int.Parse(Console.ReadLine());
                        switch (ch1)
                        {
                            case 1:
                                Console.WriteLine("\nCount : " + arr.Count);
                                Console.WriteLine("\n");
                                break;
                            case 2:
                                Console.WriteLine("\nSorted Array ; ");
                                arr.Sort();
                                foreach (var i in arr)
                                {
                                    Console.Write(i + "\t");
                                }
                                break;
                            case 3:
                                Console.WriteLine("\nDisplay Array : ");
                                foreach (var i in arr)
                                {
                                    Console.Write(i + "\t");
                                }
                                Console.WriteLine("\n");
                                break;
                            case 4:
                                Console.WriteLine("\nRemove value by digit : ");
                                Console.Write("\nEnter the digit : ");
                                int temp = int.Parse(Console.ReadLine());
                                arr.Remove(temp);
                                foreach (var i in arr)
                                {
                                    Console.Write(i + "\t");
                                }
                                Console.WriteLine("\n");
                                break;
                            case 5:
                                Console.WriteLine("\nRemove value by digit : ");
                                Console.Write("\nEnter the digit : ");
                                int temp1 = int.Parse(Console.ReadLine());
                                arr.RemoveAt(temp1);
                                foreach (var i in arr)
                                {
                                    Console.Write(i + "\t");
                                }
                                Console.WriteLine("\n");
                                break;
                            default:
                                Console.WriteLine("\nInvalid Input");
                                Console.WriteLine("\n");
                                break;
                        }
                    }
                    break;
                case 2 :
                    Console.WriteLine("Enter the number of elements : ");
                    int n2 = int.Parse(Console.ReadLine());
                    Stack s1 = new Stack(n2);
                    Console.Write("Push elements "+n2+" : ");
                    for(int i2 = 0; i2 < n2; i2++)
                    {
                        s1.Push(Console.ReadLine());
                    }

                    Console.Write("Given Array is : \t");
                    foreach(var i in s1)
                    {
                        Console.Write(i+"\t");
                    }

                    Console.Write("\nEnter number of element to Pop : ");
                    int p2 = int.Parse(Console.ReadLine());
                    for(int i2 = 0; i2 < p2; i2++)
                    {
                        s1.Pop();
                    }

                    Console.Write("\nAfter Pop : \t");
                    foreach(var i in s1)
                    {
                        Console.Write(i + "\t");
                    }
                    break;

                case 3:
                    Console.Write("\n\nEnter Number of elements : ");
                    int n3 = int.Parse(Console.ReadLine());
                    SortedList<int, string> sort1 = new SortedList<int, string>(n3);
                    Console.Write("Enter elements (int, string): ");
                    for(int i3 = 0; i3 < n3; i3++)
                    {
                        sort1.Add(int.Parse(Console.ReadLine()), Console.ReadLine());
                    }

                    Console.WriteLine("Given Elements : ");
                    foreach(var i in sort1.Keys)
                    {
                        Console.Write(i+" "+sort1[i]+"\n");
                    }
                    break;

                case 4:
                    Console.WriteLine("\n\nEnter number of hashtable : ");
                    int n4 = int.Parse(Console.ReadLine());
                    Hashtable h1 = new Hashtable(n4);

                    Console.WriteLine("Enter key and value : ");
                    for (int i4 = 0; i4 < n4; i4++)
                    {
                        h1.Add(Console.ReadLine(), Console.ReadLine());
                    }

                    Console.WriteLine("Display Hash Table : ");
                    foreach (var i in h1.Keys)
                    {
                        Console.WriteLine(i + " " + h1[i]);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadKey();
        }
    }
}
