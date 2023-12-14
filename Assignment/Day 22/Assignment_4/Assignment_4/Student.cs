using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_4
{
    
    public class Student
    {
        public string grade;
        public string display(string name, string college, string subject, string branch)
        {
            return "Name : " + name + "<br/>College : " + college + "<br/>Subject : " + subject +
                   "<br/>Branch : " + branch;
        }
        public string cal_grade(int per)
        {
            if(per > 60)
            {
                grade = "Grade A";
            }
            else if (per > 50 && per < 60 )
            {
                grade = "Grade B";
            }
            else
            {
                grade = "Fail";
            }
            return per.ToString();
        }
    }
}