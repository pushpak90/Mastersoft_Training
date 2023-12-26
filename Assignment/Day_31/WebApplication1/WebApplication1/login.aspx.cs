using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            
           
            try
            {
                if(txtEmail.Text == "" || txtPasswrod.Text == "")
                {
                    Response.Write("Provide all Field");
                }
                else
                {
                    Session["s_email"] = txtEmail.Text;
                    Session["s_password"] = txtPasswrod.Text;
                    l1.login(txtEmail.Text, txtPasswrod.Text);
                }
            }
            catch
            {

            }
        }
    }
}