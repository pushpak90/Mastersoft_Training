using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            t_date.Text = DateTime.Now.ToString("dd/MMM/yyyy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx?name=" + t_name.Text +
                "&email="+t_email.Text+"&mobile="+t_mobile.Text+"&password="+t_password.Text);
        }
    }
}