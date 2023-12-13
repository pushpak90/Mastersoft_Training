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
            Button1.Attributes.Add("onclick", "javascript: return NotEmptyPasswordEmail()");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtEmail.Text == "" || txtPassword.Text == "")
                {
                    Response.Write("All field are require");
                }
                else
                {
                    Session["email"] = txtEmail.Text;
                    ViewState["password"] = txtPassword.Text;
                    if ((string)Session["email"] == Request.QueryString["email_q"] && (string)Session["pass"] == ViewState["password"].ToString())
                    {
                        Response.Redirect("Exam.aspx");
                    }
                    else
                    {
                        Response.Write("Invalid User");
                    }
                }
                
            }
            catch(Exception p1)
            {

            }
        }
    }
}