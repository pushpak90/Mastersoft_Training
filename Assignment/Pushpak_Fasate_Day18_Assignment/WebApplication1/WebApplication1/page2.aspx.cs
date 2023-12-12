using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            l_name.Text = Request.QueryString["name"];
            l_email.Text = Request.QueryString["email"];
            l_city.Text = Request.QueryString["city"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page3.aspx?branch=" + t_branch.Text +
                "&sub=" + t_sub.Text +
                "&name="+ Request.QueryString["name"] + 
                "&email=" + Request.QueryString["email"]+
                "&city="+Request.QueryString["city"]
                );
        }
    }
}