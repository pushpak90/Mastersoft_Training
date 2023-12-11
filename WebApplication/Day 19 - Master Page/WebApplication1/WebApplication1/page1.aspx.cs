using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["name"] = TextBox1.Text;
            Application["email"] = TextBox2.Text;
            Application["password"] = TextBox3.Text;
            Application["date"] = TextBox4.Text;

            if (TextBox4.Text == DateTime.Now.ToString("dd/MMM/yyyy"))
            {
                Response.Redirect("Login1.aspx");
            }
            else
            {
                Response.Write("Invalid");
            }
        }
    }
}