using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "HelloWorld";
            Console.WriteLine("Given string : " + name);
            Console.WriteLine("Length of string : "+name.Length);
            Console.WriteLine("Convter in upper case : " + name.ToUpper());
            Console.WriteLine("Convter in lower case : " + name.ToLower());
            string s_name = "Animal";
            Console.WriteLine("String 2 " + s_name);
            Console.WriteLine("Concat String : " + String.Concat(name+" ", s_name));
            Console.WriteLine("Using Index value"+name[0]);
            Console.WriteLine("print index using char : " + name.IndexOf('H'));
            Console.ReadKey();
        }
    }
}
