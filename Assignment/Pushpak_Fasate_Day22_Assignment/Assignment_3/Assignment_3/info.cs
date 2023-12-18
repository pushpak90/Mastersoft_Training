using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_3
{
    public class info
    {
        public string grade;
        public string input(string name, string city, string college, string branch, int per)
        {
            if (per > 60)
            {
                grade = "Grade A";
            }
            else if (per > 50 && per < 60)
            {
                grade = "Grade B";
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