using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class student
    {
        public string message;
        public string display()     //returing data to aspx page
        {
            message = "This is my first class program";
            return message;
        }
        public int addition(int  a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
    }
}