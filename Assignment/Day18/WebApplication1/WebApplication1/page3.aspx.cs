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
            l_branch.Text = Request.QueryString["branch"];
            l_sub.Text = Request.QueryString["sub"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("finish.aspx?college="+t_col.Text+
                "&prin="+t_prin.Text+
                "&branch=" + Request.QueryString["branch"]+ 
                "&sub=" + Request.QueryString["sub"]+
                "&name="+ Request.QueryString["name"] + 
                "&email=" + Request.QueryString["email"]+
                "&city="+Request.QueryString["city"]
                );
        }
    }
}