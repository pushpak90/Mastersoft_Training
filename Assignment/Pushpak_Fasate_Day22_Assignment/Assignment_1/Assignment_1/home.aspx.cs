using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
                {
                    Response.Write("All Field Are Require");
                }
                else
                {
                    Response.Cookies["name"].Value = txtName.Text;
                    Response.Cookies["email"].Value = txtEmail.Text;
                    Response.Cookies["password"].Value = txtPassword.Text;
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    Response.Redirect("login.aspx");
                }
                
            }
            catch (Exception ob)
            {

            }
            
        }
    }
}