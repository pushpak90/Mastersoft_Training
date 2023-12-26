using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Departmentlogin_aspx : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            deptlogin dl = new deptlogin();
            try
            {
                if (txtEmail.Text == "" || txtPasswrod.Text == "")
                {
                    Response.Write("Provide all Field");
                }
                else
                {
                    Session["d_email"] = txtEmail.Text;
                    Session["d_password"] = txtPasswrod.Text;
                    dl.logdept(txtEmail.Text, txtPasswrod.Text);
                }
            }
            catch
            {

            }
        }
    }
}