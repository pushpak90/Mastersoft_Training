using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class deptmark
    {
        SqlConnection _connection;
        SqlCommand _command;
        public SqlDataReader _reader;
        public string show_grid(string f_dept)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            _connection = new SqlConnection(path);
            _connection.Open();

            string ss_q = "select * From ActivityDB WHERE dept = @dept1";
            _command = new SqlCommand(ss_q, _connection);
            _command.Parameters.AddWithValue("dept1",f_dept);

            _reader = _command.ExecuteReader();
            return "Done";
        }

        public string find_name(string f_name)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            _connection = new SqlConnection(path);
            _connection.Open();

            string ss_q = "select * From StudentRegDb where Name = @Name1;";

            _command = new SqlCommand(ss_q, _connection);
            _command.Parameters.AddWithValue("@Name1",f_name);
            _reader = _command.ExecuteReader();
            // Connect data control to grid view
            return "Done";
        }

    }
}