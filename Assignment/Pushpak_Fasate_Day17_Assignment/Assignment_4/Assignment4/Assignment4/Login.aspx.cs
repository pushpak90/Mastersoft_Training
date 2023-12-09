using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(l_email.Text == "" || l_password.Text == "")
            {
                Response.Write("Provide All Field");
            }
            else
            {
                if (l_email.Text == (string)Session["email"] && l_password.Text == (string)Session["password"])
                {
                    Response.Redirect("exam.aspx");
                }
                else
                {
                    Response.Write("Invalid User");
                }
            }
        }
    }
}