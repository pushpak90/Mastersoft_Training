using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;

namespace Online_Student_Complained
{
    public class student_reg
    {
        SqlConnection _connection;
        SqlCommand _com;
        public SqlDataReader _reader;
        public string f_dept;
        public string insert_q(string f_colName, string f_name, string f_branch, string f_email, string f_mobile, 
            string f_sem, string f_pass, string f_date)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            _connection = new SqlConnection(path);
            _connection.Open();

           
            _com = new SqlCommand("insert_s", _connection);
            _com.CommandType = CommandType.StoredProcedure;

            _com.Parameters.AddWithValue("Collegename1", f_colName);
            _com.Parameters.AddWithValue("Sname1", f_name);
            _com.Parameters.AddWithValue("Branch1", f_branch);
            _com.Parameters.AddWithValue("Email1", f_email);
            _com.Parameters.AddWithValue("Mobile1", f_mobile);
            _com.Parameters.AddWithValue("Semester1", f_sem);
            _com.Parameters.AddWithValue("Pass_word1", f_pass);
            _com.Parameters.AddWithValue("C_Date1", f_date);

            _com.ExecuteNonQuery();

            HttpContext.Current.Response.Write("data inserted");


            return "Done";
        }
    }
}