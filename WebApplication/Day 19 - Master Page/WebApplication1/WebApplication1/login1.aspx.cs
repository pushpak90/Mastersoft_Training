using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["email_v"] = TextBox1.Text;
            ViewState["password_v"] = TextBox2.Text;
            if (Application["email"].ToString() == ViewState["email_v"].ToString() &&
                Application["password"].ToString() == ViewState["password_v"].ToString())
            {
                Label1.Text = Application["name"].ToString();
                Label5.Text = ViewState["email_v"].ToString();
                Label3.Text = ViewState["password_v"].ToString();
                Label4.Text = Application["date"].ToString();
            }
        }
    }
}