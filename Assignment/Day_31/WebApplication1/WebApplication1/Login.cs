using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class Login
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       

        public string login(string f_email, string f_password)
        {
            //creating session
            HttpContext.Current.Session["c_s_email"] = f_email;
            HttpContext.Current.Session["c_s_password"] = f_password;
           
            //Session["s_email"] = txtEmail.Text;
            string path = ConfigurationManager.AppSettings["Mark"];
            con = new SqlConnection(path);
            con.Open();

            string match = "Select * from StudentRegDb where Email = @Email1 AND Password = @Password1";
            cmd = new SqlCommand(match, con);
            cmd.Parameters.AddWithValue("Email1", f_email);
            cmd.Parameters.AddWithValue("Password1", f_password);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Response.Redirect("Student_activity.aspx");
                HttpContext.Current.Response.Redirect("Student_activity.aspx");
                //HttpContext.Current.Response.Write("Login");
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
                HttpContext.Current.Response.Write("Invalid");
            }
            dr.Close();
            return "Login Done";
        }
    }
}