using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Online_Student_Complained
{
    public class stucomp
    {
        SqlConnection _conn;
        SqlCommand _command;
        public SqlDataReader _reader;

        public string f_insert(string f_cname, string f_sname, string f_email, string f_branch, string f_complaint,
            string f_message, string f_date)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            _conn = new SqlConnection(path);
            _conn.Open();

            _command = new SqlCommand("complaininsert", _conn);
            _command.CommandType = CommandType.StoredProcedure;

            _command.Parameters.AddWithValue("Collegename1", f_cname);
            _command.Parameters.AddWithValue("Sname1", f_sname);
            _command.Parameters.AddWithValue("Email1", f_email);
            _command.Parameters.AddWithValue("Branch1", f_branch);
            _command.Parameters.AddWithValue("Complainto1", f_complaint);
            _command.Parameters.AddWithValue("msg1", f_message);
            _command.Parameters.AddWithValue("C_date1", f_date);

            _command.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Inserted");

            return "Done";
        }

        public string show_grid(string f_colname)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            _conn = new SqlConnection(path);
            _conn.Open();

            _command = new SqlCommand("show_comp_grid", _conn);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("para1", f_colname);
            _reader = _command.ExecuteReader();

            return "Done";
        }

        public string del_rec(string f_name, string f_sname, string f_branch, string f_comp, string f_msg)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            _conn = new SqlConnection(path);
            _conn.Open();

            _command = new SqlCommand("del_rec", _conn);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Collegename1", f_name);
            _command.Parameters.AddWithValue("Sname1", f_sname);
            _command.Parameters.AddWithValue("Branch1", f_branch);
            _command.Parameters.AddWithValue("Complainto1", f_comp);
            _command.Parameters.AddWithValue("msg1", f_msg);
            _reader = _command.ExecuteReader();

            HttpContext.Current.Response.Redirect("studentcomplaint.aspx");
            HttpContext.Current.Response.Write("Delete");

            return "Done";
        }
    }
}