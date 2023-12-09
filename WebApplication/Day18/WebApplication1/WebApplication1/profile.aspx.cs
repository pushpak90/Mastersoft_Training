using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["email"];
            Label2.Text = Request.QueryString["mobile"];
            Label3.Text = Request.QueryString["city"];
            Label4.Text = Request.QueryString["branch"];

            Label5.Text = Request.QueryString["college"];
            Label6.Text = Request.QueryString["pri"];

        }
    }
}