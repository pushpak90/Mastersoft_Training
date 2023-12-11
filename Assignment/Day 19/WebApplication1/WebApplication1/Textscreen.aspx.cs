using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Textscreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            col_name.Text = (string)Session["col_name"];
            l_name.Text = (string)Session["name"];
            l_email.Text = (string)Session["email"];
            l_sem.Text = (string)Session["sem"];
            Image1.ImageUrl = "~/upload/"+(string)Session["img"];
        }
    }
}