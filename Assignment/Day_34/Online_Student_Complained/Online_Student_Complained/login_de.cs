using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace Online_Student_Complained
{
    public class login_de
    {
        SqlConnection _conn;
        SqlCommand  _command;
        SqlDataReader _reader;
        public string coll_name;

        public string passemail(string f_email, string f_password)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            _conn = new SqlConnection(path);
            _conn.Open();
            
            _command = new SqlCommand("Login_coll",_conn);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Email1",f_email);
            _command.Parameters.AddWithValue("Password1",f_password);
            _command.Parameters.AddWithValue("Collegecode1", f_email);

            _reader = _command.ExecuteReader();


            if (_reader.Read())
            {
                if (_reader["Collegecode"].ToString() == f_email && _reader["Passwo"].ToString() == f_password)
                {
                    HttpContext.Current.Session["s_col"] = _reader["Collegename"].ToString();
                    HttpContext.Current.Session["s_email"] = _reader["Email"].ToString();
                    HttpContext.Current.Session["s_pass"] = _reader["Passwo"].ToString();
                    HttpContext.Current.Response.Redirect("Collegeadmin.aspx");
                }
                else if (_reader["Email"].ToString() == f_email && _reader["Passwo"].ToString() == f_password)
                {
                    HttpContext.Current.Session["s_col"] = _reader["Collegename"].ToString();
                    HttpContext.Current.Session["s_email"] = _reader["Email"].ToString();
                    HttpContext.Current.Session["s_pass"] = _reader["Passwo"].ToString();
                    HttpContext.Current.Response.Redirect("Collegeadmin.aspx");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("Invalid User");
            }
            _reader.Close();
            return coll_name;
        }
    }
}