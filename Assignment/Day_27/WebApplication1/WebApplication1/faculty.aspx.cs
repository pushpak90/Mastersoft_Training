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
    public partial class faculty : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["l_email"] = txtEmail.Text;
            Session["l_password"] = txtPassword.Text;
            string path = ConfigurationManager.AppSettings["faculty"];
            conn = new SqlConnection(path);
            conn.Open();
            string login_q = "Select * from facultylogin";
            cmd = new SqlCommand(login_q, conn);
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                if ((string)Session["l_email"] == rdr["Email"].ToString() && int.Parse(txtPassword.Text) == int.Parse(rdr["password"].ToString()))
                {
                    Response.Redirect("det.aspx");
                }
                else
                {
                    Response.Write("invalid");
                }
            }
            else
            {
                Response.Write("invalid");
            }
            rdr.Close();
        }
    }
}