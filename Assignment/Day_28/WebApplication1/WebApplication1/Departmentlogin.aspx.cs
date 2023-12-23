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
            try
            {
                if (txtEmail.Text == "" || txtPasswrod.Text == "")
                {
                    Response.Write("Provide all Field");
                }
                else
                {
                    Session["s_email"] = txtEmail.Text;
                    string path = ConfigurationManager.AppSettings["Mark"];
                    conn = new SqlConnection(path);
                    conn.Open();

                    string match = "Select * from deptlogindb where fac_id = @fac_id1 AND password = @password1";
                    cmd = new SqlCommand(match, conn);
                    cmd.Parameters.AddWithValue("@fac_id1",txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password1", txtPasswrod.Text);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Response.Redirect("Deptmark.aspx");
                        /*
                        if (txtEmail.Text == reader["fac_id"].ToString() && int.Parse(txtPasswrod.Text) == int.Parse(reader["Password"].ToString()))
                        {
                           
                        }
                        else
                        {
                            Response.Write("Invalid");
                        }
                        */
                    }
                    else
                    {
                        Response.Write("Invalid");
                    }
                    reader.Close();
                }
            }
            catch
            {

            }
        }
    }
}