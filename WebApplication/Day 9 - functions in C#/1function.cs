using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        //Crate a function 
        void display(int a)  //function defination
        {
            Console.WriteLine("Welcome to my program");
            Console.WriteLine("Given Number : "+a);
        }
        static void Main(string[] args)
        {
            //Create Object 
            // class_name obj_name = new class_name();
            Program p1 = new Program();

            Console.Write("Enter Number : ");
            int no = int.Parse(Console.ReadLine());

            p1.display(no);   //function calling

            Console.ReadKey();
        }
    }
}
