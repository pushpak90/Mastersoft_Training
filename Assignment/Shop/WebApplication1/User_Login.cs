using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class User_Login
    {
        SqlConnection _conn;
        SqlCommand _command;
        SqlDataReader _reader;

        public string check_user(string f_email, string f_password)
        {
            string connecting_string = ConfigurationManager.AppSettings["shop"];
            _conn = new SqlConnection(connecting_string);
            _conn.Open();

            string login_q = "SELECT * FROM Login_shop where Email_s = @Email_s1 AND Password_s = @Password_s1";
            _command = new SqlCommand(login_q, _conn);
            _command.Parameters.AddWithValue("Email_s1", f_email);
            _command.Parameters.AddWithValue("Password_s1", f_password);
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                if (f_email == _reader["Email_s"].ToString() && f_password == _reader["Password_s"].ToString())
                {

                    HttpContext.Current.Response.Write("Valid User");
                    HttpContext.Current.Response.Redirect("Selectoperation.aspx");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("Invalid User");
            }
            return "Done";
        }
    }
}