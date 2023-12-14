using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class myclass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // classname ob = new classname();
            student s1 = new student();
            Label1.Text = s1.display();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            student s1 = new student();
            int a1, b1, c1;
            a1 = int.Parse(TextBox1.Text);
            b1 = int.Parse(TextBox1.Text);
            c1 = s1.addition(a1, b1);
            TextBox3.Text = c1.ToString();
        }
    }
}