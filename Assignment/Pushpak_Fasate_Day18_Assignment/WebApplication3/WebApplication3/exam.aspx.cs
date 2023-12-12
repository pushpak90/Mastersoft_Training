using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            l_name.Text = Request.QueryString["name"];
            l_email.Text = Request.QueryString["email"];
            l_mobile.Text = Request.QueryString["mobile"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Genrateexam.aspx?branch="+DropDownList1.SelectedValue+"&sem="+
                DropDownList1.SelectedValue+"&shift="+DropDownList1.SelectedValue+
                "&name="+Request.QueryString["name"]+"&email="+Request.QueryString["email"]
                +"&mobile="+Request.QueryString["mobile"]);
        }
    }
}