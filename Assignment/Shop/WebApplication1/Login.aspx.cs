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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection _conn;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User_Login l1 = new User_Login();
            l1.check_user(txtEmail.Text, txtPassword.Text);
        }
    }
}