using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace day15_assignment
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            int roll, m1, m2, m3, m4, m5, total;
            string name, email, mobile, sub, branch, grade;

            if(TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == ""
                || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == ""
                || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == ""
                || TextBox10.Text == "" || TextBox11.Text == "")
            {
                Response.Write("All field are require");
            }
            else
            {
                roll = int.Parse(TextBox1.Text);
                name = TextBox2.Text;
                email = TextBox2.Text;
                mobile = TextBox3.Text;
                sub = TextBox4.Text;
                branch = TextBox6.Text;
                m1 = int.Parse(TextBox7.Text);
                m2 = int.Parse(TextBox8.Text);
                m3 = int.Parse(TextBox9.Text);
                m4 = int.Parse(TextBox10.Text);
                m5 = int.Parse(TextBox11.Text);

                if (m1 >= 40 && m2 >= 40 && m3 >= 40 && m4 >= 40 && m5 >= 40)
                {
                    total = m1 + m2 + m3 + m4 + m5;
                    TextBox12.Text = total.ToString();
                    if (total > 250)
                    {
                        grade = "Grade A";
                    }
                    else if (total > 150 && total < 250)
                    {
                        grade = "Grade B";
                    }
                    else if (total > 100 && total < 150)
                    {
                        grade = "Grade C";
                    }
                    else
                    {
                        grade = "Fail";
                    }
                    TextBox13.Text = grade;
                }
                else
                {
                    Response.Write("All Marks show be greater than 40");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string m_name, m_sub, m_grade;
            int m_m1, m_m2, m_m3, m_m4, m_m5;
            m_name = TextBox2.Text;
            m_sub = TextBox5.Text;
            m_m1 = int.Parse(TextBox7.Text);
            m_m2 = int.Parse(TextBox8.Text);
            m_m3 = int.Parse(TextBox9.Text);
            m_m4 = int.Parse(TextBox10.Text);
            m_m5 = int.Parse(TextBox11.Text);
            int m_total = m_m1 + m_m2 + m_m3 + m_m4 + m_m5;
            if (m_total > 250)
            {
                m_grade = "Grade A";
            }
            else if (m_total > 150 && m_total < 250)
            {
                m_grade = "Grade B";
            }
            else if (m_total > 100 && m_total < 150)
            {
                m_grade = "Grade C";
            }
            else
            {
                m_grade = "Fail";
            }
            TextBox13.Text = m_grade;
            Response.Write("Dear Student,<br>Name : "+m_name+"<br>Subject : "+m_sub+"<br>Total : "+m_total+"<br>Grade : "+m_grade);
            outputscreen.InnerText = "Thanks for visit my web page.";
        }
    }
}