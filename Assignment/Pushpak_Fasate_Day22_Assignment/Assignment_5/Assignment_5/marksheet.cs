using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_5
{
    public class marksheet
    {
        public string g_grade;
        public string display(string name, string city, string college)
        {
            return "Name : " + name + "<br/>City : " + city + "<br/>College : " + college;
        }
        public int total(int m1, int m2, int m3, int m4, int m5)
        {
            int total;
            total = m1 + m2 + m3 + m4 + m5;
            if (total > 250)
            {
                g_grade = "Grade A";
            }
            else if (total > 150 && total < 250)
            {
                g_grade = "Grade B";
            }
            else if(total > 100 && total < 150)
            {
                g_grade = "Grade C";
            }
            else
            {
                g_grade = "Fail";
            }
            return total;
        }
    }
}