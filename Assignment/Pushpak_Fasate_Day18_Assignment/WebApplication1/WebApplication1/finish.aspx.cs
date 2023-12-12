using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class finish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            l_name.Text = Request.QueryString["name"];
            l_email.Text = Request.QueryString["email"];
            l_city.Text = Request.QueryString["city"];
            l_branch.Text = Request.QueryString["branch"];
            l_sub.Text = Request.QueryString["sub"];
            l_col.Text = Request.QueryString["college"];
            l_prin.Text = Request.QueryString["prin"];
        }
    }
}