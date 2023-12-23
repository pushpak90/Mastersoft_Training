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
                if(txtEmail.Text == "" || txtPasswrod.Text == "")
                {
                    Response.Write("Provide all Field");
                }
                else
                {
                    Session["s_email"] = txtEmail.Text;
                    string path = ConfigurationManager.AppSettings["Mark"];
                    conn = new SqlConnection(path);
                    conn.Open();

                    string match = "Select * from StudentRegDb where Email = @Email1 AND Password = @Password1";
                    cmd = new SqlCommand(match, conn);
                    cmd.Parameters.AddWithValue("@Email1", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password1",txtPasswrod.Text);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Response.Redirect("Student_activity.aspx");
                        /*
                        if (txtEmail.Text == reader["Email"].ToString() && int.Parse(txtPasswrod.Text) == int.Parse(reader["Password"].ToString()))
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