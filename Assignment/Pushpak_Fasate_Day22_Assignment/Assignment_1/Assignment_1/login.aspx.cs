using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Cookies["email"].Expires = DateTime.Now.AddSeconds(1);
            Response.Cookies["password"].Expires = DateTime.Now.AddSeconds(1);

            if (Request.Cookies["email"].Value == "" && Request.Cookies["password"].Value == "")
            {
                Response.Redirect("home.aspx");
            }
            else if (Request.Cookies["email"].Value == txtEmail.Text && Request.Cookies["password"].Value == txtPassword.Text)
            {
                Response.Write("Valid User");
            }
            else
            {
                Response.Write("Invalid User");
            }
        }
    }
}