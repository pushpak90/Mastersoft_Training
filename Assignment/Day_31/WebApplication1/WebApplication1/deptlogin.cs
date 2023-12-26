using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class deptlogin
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        
        public string logdept(string f_email, string f_password)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            conn = new SqlConnection(path);
            conn.Open();

            string match = "Select * from deptlogindb where fac_id = @fac_id1 AND password = @password1";
            cmd = new SqlCommand(match, conn);
            cmd.Parameters.AddWithValue("@fac_id1", f_email);
            cmd.Parameters.AddWithValue("@password1", f_password);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                HttpContext.Current.Response.Redirect("Deptmark.aspx");
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
                HttpContext.Current.Response.Write("Invalid");
            }
            reader.Close();

            return "Done";
        }
    }
}