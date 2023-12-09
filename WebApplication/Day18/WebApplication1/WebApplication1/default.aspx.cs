using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Query string implimentation
            Response.Redirect("page2.aspx?email="+TextBox1.Text+"&mobile="+TextBox2.Text+"&city="+TextBox3.Text);
        }
    }
}