using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string str = Console.ReadLine();
            Console.Write("1.Count\n2.To Upper\n3.To Lower\n4.Concat\n5.Print char using Index" +
                "\n6.Print index using char\nEnter Your Choice : ");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("\nLength of string : "+str.Length);
                    break;
                case 2:
                    Console.WriteLine("\nIn Upper Case : "+str.ToUpper());
                    break;
                case 3:
                    Console.WriteLine("\nIn Lower Case : " + str.ToLower());
                    break;
                case 4:
                    Console.Write("\nEnter String to concat : ");
                    string str2 = Console.ReadLine();
                    Console.WriteLine("\nConcat two String :"+String.Concat(str+" "+str2));
                    break;
                case 5:
                    Console.Write("\nEnter index number : ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nChar at index " + n + " : " + str[n]);
                    break;
                case 6:
                    Console.Write("\nEnter char : ");
                    string chr = Console.ReadLine();
                    Console.WriteLine("\n"+ch + " is present at  " + str.IndexOf(chr));
                    break;
            }
            Console.ReadKey();
        }
    }
}
