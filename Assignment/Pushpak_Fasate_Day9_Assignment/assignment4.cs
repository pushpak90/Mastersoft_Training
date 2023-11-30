using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web
{
    class Program
    {
        public Tuple<string, string, string, int> input(string nname,string ncity, string ncountry, int nphone)
        {
            return new Tuple<string, string, string, int>(nname,ncity, ncountry, nphone);
        }
        static void Main(string[] args)
        {
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("Country : ");
            string country = Console.ReadLine();
            Console.Write("Phone : ");
            int phone = int.Parse(Console.ReadLine());

            Program p1 = new Program();
            var mess = p1.input(name, city, country, phone);
            Console.WriteLine();
            Console.WriteLine(mess);
            Console.WriteLine("Name : "+mess.Item1);
            Console.WriteLine("City : " + mess.Item2);
            Console.WriteLine("Country : " + mess.Item3);
            Console.WriteLine("Phone : "+mess.Item4);


            Console.ReadKey();
        }
    }
}
