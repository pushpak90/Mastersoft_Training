using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx?email=" + Request.QueryString["email"] + "&mobile="
                + Request.QueryString["mobile"] + "&branch=" + Request.QueryString["branch"] +
                "&Sub=" + Request.QueryString["sub"] + "&college="+TextBox1.Text+"&pri="+TextBox2
                );
        }
    }
}