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
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            stusub s1 = new stusub();
            try
            {
                if(txtId.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" )
                {
                    Response.Write("Provide all Field");
                }
                else
                {
                    string dept = ddlBranch.SelectedValue;
                    txtId.Text = s1.input_data(txtId.Text, txtName.Text, txtEmail.Text, dept,txtPassword.Text);
                }
            }
            catch 
            {
                
            }
        }
    }
}