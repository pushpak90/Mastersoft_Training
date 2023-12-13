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
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ViewState["email"] = txtEmail.Text;
        }
        
        protected void Btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" && txtEmail.Text == "" && txtPassword.Text == "" && txtMobile.Text == "")
                {
                    Response.Write("All File Are require");
                }
                else
                {
                    Session["name"] = txtName.Text;
                   
                    Session["pass"] = txtPassword.Text;
                    Session["mobile"] = txtMobile.Text;
                    img.SaveAs(Server.MapPath("~") + "//upload//" + img.FileName);
                    Session["img"] = img.FileName;

                    if (ViewState["email"].ToString() == (string)Session["email"])
                    {
                        Response.Write("Duplicate Email");
                    }
                    else
                    {
                        Response.Redirect("Login.aspx?email_q=" + txtEmail.Text);
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