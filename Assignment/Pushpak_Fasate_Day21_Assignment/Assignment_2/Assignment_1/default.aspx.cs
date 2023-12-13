using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtpassword.Text == "" || txtemail.Text == "" ||
                txtpin.Text == "" || txtcemail.Text == "" || txtpassword.Text == "")
            {
                Response.Write("All Field are require");
            }
            else
            {
                Session["name"] = txtname.Text;
                Session["email"] = txtemail.Text;
                Session["pincode"] = txtpin.Text;
                Session["c_email"] = txtcemail.Text;
                Session["mobile"] = txtphone.Text;
                Session["password"] = txtpassword.Text;
                Response.Redirect("message.aspx");
            }
            
        }
    }
}