using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_try_catch_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //create sting builder class object
            StringBuilder sb = new StringBuilder("Welcome",5);
            //1. display stringbulder data value
            for(int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]+"\t");
            }
            
            //retrive sting bulider data value
            var data1 = sb.ToString();
            Console.WriteLine("\n\n"+data1);

            //append data type in string builder
            sb.Append("Hello");
            Console.WriteLine(sb);

            sb.AppendLine("World");
            Console.WriteLine(sb);

            //Insert data element 
            sb.Insert(1,"mumbai");
            Console.WriteLine(sb);

            //replace string
            sb.Replace("mumbai","pune");
            Console.WriteLine(sb);

            //remoove string
            sb.Remove(3,5);         // 3 - stating point 5 - length
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
