using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_3
{
    public class info
    {
        public string grade;
        public string input(string name, string city, string college, string branch, string per)
        {
            int mark = int.Parse(per);
            if (mark > 250)
            {
                grade = "Grade A";
            }
            else if (mark > 150 && mark < 250)
            {
                grade = "Grade B";
            }
            else if (mark > 100 && mark < 150)
            {
                grade = "Grade C";
            }
            else
            {
                grade = "Fail";
            }
            return "Name : " + name + "<br/>City : " + city + "<br/>College : " + college + "<br/>Branch : "
                    + branch + "<br/>Percentage : " + per;
        }
    }
}