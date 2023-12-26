using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class deptmaster
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        public string p_id, p_dept;
        public string display(string f_email, string f_password)
        {

            string path = ConfigurationManager.AppSettings["Mark"];
            _connection = new SqlConnection(path);
            _connection.Open();

            string ss_q = "select * From deptlogindb where fac_id = @fac_id1 and password = @password1";
            _command = new SqlCommand(ss_q, _connection);
            _command.Parameters.AddWithValue("@fac_id1", f_email);
            _command.Parameters.AddWithValue("@password1", f_password);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                p_id = _reader["fac_id"].ToString();
                p_dept = _reader["dept"].ToString();
                
            }
            _reader.Close();
            return "Done";
        }
    }
}