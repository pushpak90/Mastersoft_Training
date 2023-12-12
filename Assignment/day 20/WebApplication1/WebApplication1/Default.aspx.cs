using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            T_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ViewState["email"] = t_email.Text;
        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_name.Text == "" && t_email.Text == "" && t_password.Text == "" && t_mobile.Text == "")
                {
                    Response.Write("All File Are require");
                }
                else
                {
                    Session["name"] = t_name.Text;
                   
                    Session["pass"] = t_password.Text;
                    Session["mobile"] = t_mobile.Text;
                    img.SaveAs(Server.MapPath("~") + "//upload//" + img.FileName);
                    Session["img"] = img.FileName;

                    if (ViewState["email"].ToString() == (string)Session["email"])
                    {
                        Response.Write("Duplicate Email");
                    }
                    else
                    {
                        Response.Redirect("Login.aspx?email_q=" + t_email.Text);
                    }
                    
                }
            }
            catch(Exception d)
            {
                Response.Write(d.ToString());
            }
            
        }
    }
}