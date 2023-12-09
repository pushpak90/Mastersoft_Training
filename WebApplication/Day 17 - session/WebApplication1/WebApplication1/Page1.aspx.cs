using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //session create
            //session["Variable"] = value;
            Session["email"] = TextBox1.Text;
            Session["mobile"] = TextBox2.Text;
            Response.Redirect("Page2.aspx");
        }
    }
}