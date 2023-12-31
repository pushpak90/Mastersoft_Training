using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Online_Student_Complained
{
    public class logstu
    {
        SqlConnection _conn;
        SqlCommand _command;
        SqlDataReader _reader;
        public string passemail(string f_email, string f_password)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            _conn = new SqlConnection(path);
            _conn.Open();

            _command = new SqlCommand("Login_stu", _conn);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Email1", f_email);
            _command.Parameters.AddWithValue("Password1", f_password);

            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                if (_reader["Email"].ToString() == f_email && _reader["Pass_word"].ToString() == f_password)
                {
                    HttpContext.Current.Session["s_Email"] = _reader["Email"].ToString();
                    HttpContext.Current.Session["s_name"] = _reader["Sname"].ToString();
                    HttpContext.Current.Session["s_college"] = _reader["Collegename"].ToString();
                    HttpContext.Current.Session["s_branch"] = _reader["Branch"].ToString();
                    HttpContext.Current.Response.Redirect("studentpanel.aspx");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("Invalid User");
            }

            _reader.Close();
            return "Done";
        }
    }
}