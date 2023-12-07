using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace m_view
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            string name, city, college, email, mobile;
            if (textname.Text == "" || textcity.Text == "" || textcollege.Text == "" || textemail.Text == "" || textmobile.Text == "")
            {
                Response.Write("Require all fields");
            }
            else
            {
                name = textname.Text;
                city = textcity.Text;
                college = textcollege.Text;
                email = textemail.Text;
                mobile = textmobile.Text;
                label_name.Text = name;
                label_college.Text = college;
                label_name_3.Text = name;
                label_college_name_3.Text = college;
                label4_name.Text = name;
                label4_email.Text = email;
                label4_mobile.Text = mobile;
                label5_name.Text = name;
                label5_city.Text = city;
                label5_college.Text = college;
                label5_email.Text = email;
                label5_mobile.Text = mobile;
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
            string branch, sem, sub;
            if(textbranch.Text == "" || textsem.Text == "" || textsub.Text == "")
            {
                Response.Write("All Field are Require");
            }
            else
            {
                branch = textbranch.Text;
                sem = textsem.Text;
                sub = textsub.Text;
                label_branch_3.Text = branch;
                label4_branch.Text = branch;
                label4_subject.Text = sub;
                label5_branch.Text = branch;
                label5_sem.Text = sem;
                label5_sub.Text = sub;
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
            if(mark1.Text == "" || mark2.Text == "" || mark3.Text == "" || mark4.Text == "" || mark5.Text == "")
            {
                Response.Write("All Marks Are Require");
            }
            else
            {
                int m1 = int.Parse(mark1.Text);
                int m2 = int.Parse(mark2.Text);
                int m3 = int.Parse(mark3.Text);
                int m4 = int.Parse(mark4.Text);
                int m5 = int.Parse(mark5.Text);
                int total = m1 + m2 + m3 + m4 + m5;
                label4_total.Text = total.ToString();
                label5_total.Text = total.ToString();
                if (total >= 250)
                {
                    label4_grade.Text = "Grade A";
                    label5_grade.Text = "Grade A";
                }
                else if(total >=150 && total <=250)
                {
                    label4_grade.Text = "Grade B";
                    label5_grade.Text = "Grade B";
                }
                else if(total >=100 && total <=150)
                {
                    label4_grade.Text = "Grade C";
                    label5_grade.Text = "Grade C";
                }
                else
                {
                    label4_grade.Text = "Fail";
                    label5_grade.Text = "Fail";
                }
                label5_m1.Text = m1.ToString();
                label5_m2.Text = m2.ToString();
                label5_m3.Text = m3.ToString();
                label5_m4.Text = m4.ToString();
                label5_m5.Text = m5.ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 4;
        }
    }
}