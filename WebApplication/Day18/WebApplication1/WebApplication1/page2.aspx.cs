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
            //access query string
            Label1.Text = Request.QueryString["email"];
            Label2.Text = Request.QueryString["mobile"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("page3.aspx?email=" + Request.QueryString["email"] + "&mobile="
                +Request.QueryString["mobile"]+"&branch="+Label1.Text+"&sub="+TextBox2.Text);
        }
    }
}