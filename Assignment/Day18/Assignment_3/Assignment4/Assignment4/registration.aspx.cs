using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MMM/yyyy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(name.Text == "" || email.Text == "" || mobile.Text == "" || password.Text == "")
            {
                Response.Write("All Field Are Require");
            }
            else
            {
                Session["name"] = name.Text;
                Session["email"] = email.Text;
                Session["mobile"] = mobile.Text;
                Session["password"] = password.Text;
                FileUpload1.SaveAs(Server.MapPath("~") + "//upload//" + FileUpload1.FileName);
                Session["img"] = FileUpload1.FileName;

                Response.Redirect("Login.aspx");

                
            }
        }
    }
}