using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Online_Student_Complained
{
    public partial class Collegereg : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Collegelogin.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            collreg c1 = new collreg();
            try
            {
                if(txtCollegeName.Text == "" || txtCollegeCode.Text == "" || txtPrincipal.Text == "" || 
                    txtEmail.Text == "" || txtMobile.Text == "" || txtpassword.Text == "" )
                {
                    Response.Write("<script>alert('All Field are require')</script>");
                }
                else
                {
                    c1.intput_data(txtCollegeName.Text, txtCollegeCode.Text, txtPrincipal.Text, txtEmail.Text,
                        txtMobile.Text, txtpassword.Text, txtDate.Text);
                  
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}