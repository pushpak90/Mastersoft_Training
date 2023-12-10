using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(t_email.Text == Request.QueryString["email"] && t_password.Text == Request.QueryString["password"] )
            {
                Response.Redirect("exam.aspx?email=" + t_email.Text + 
                    "&name=" + Request.QueryString["name"] +
                    "&mobile=" + Request.QueryString["mobile"]
                    );
            }
            else
            {
                Response.Write("invalid user");
            }
        }
    }
}