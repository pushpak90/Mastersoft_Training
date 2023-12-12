using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["email"] = t_email.Text;
            ViewState["password"] = t_password.Text;
            try
            {
                if ((string)Session["email"] == Request.QueryString["email_q"] && (string)Session["pass"] == ViewState["password"].ToString())
                {
                    Response.Redirect("Exam.aspx");
                }
                else
                {
                    Response.Write("Invalid User");
                }
            }
            catch(Exception p1)
            {

            }
        }
    }
}