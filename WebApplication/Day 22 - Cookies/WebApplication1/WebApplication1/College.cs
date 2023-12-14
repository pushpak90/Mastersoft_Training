using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    
    public class College
    {
        public string g_grade;
        public int marktotal(int mark1, int mark2, int mark3, int mark4, int mark5)
        {
            int total = mark1 + mark2 + mark3 + mark4 + mark5;
            
            if (total > 250)
            {
                g_grade = "Grade A";
            }
            else
            {
                g_grade = "Grade A";
            }
            return total;
        }
    }
}