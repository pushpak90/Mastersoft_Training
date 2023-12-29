using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Online_Student_Complained
{
    public class deptuser
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public string p_colName, p_collegeCode, p_dept;

        public string page(string f_colname, string f_colcode)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("usershow", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Collegename1", f_colname);
            cmd.Parameters.AddWithValue("Collegecode1", f_colcode);

            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                p_colName = rdr["Collegename"].ToString();
                p_collegeCode = rdr["Collegecode"].ToString();
                p_dept = rdr["Deptname"].ToString();
            }

            rdr.Close();

            return "Done";
        }

        public string insert_user(string f_name, string f_code, string f_dept, string f_faculty, string f_id, 
            string f_pass, string d_date)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("insert_user", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Collegename1", f_name);
            cmd.Parameters.AddWithValue("Collegecode1", f_code);
            cmd.Parameters.AddWithValue("Deptname1", f_dept);
            cmd.Parameters.AddWithValue("Username1", f_faculty);
            cmd.Parameters.AddWithValue("Userid1", f_id);
            cmd.Parameters.AddWithValue("Userpass1", f_pass);
            cmd.Parameters.AddWithValue("D_date1", d_date);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Insert");

            return "Done";
        }

        public string update_user(string f_name, string f_dept, string f_faculty, string f_user, string f_pass)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("Update_user", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Collegename1", f_name);
            cmd.Parameters.AddWithValue("Deptname1", f_dept);
            cmd.Parameters.AddWithValue("Username1", f_faculty);
            cmd.Parameters.AddWithValue("UserId1", f_user);
            cmd.Parameters.AddWithValue("Userpass1", f_pass);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Update");

            return "Done";
        }

        public string delete_user(string f_name, string f_dept, string f_faculty, string f_user, string f_pass)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("delete_user", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Collegename1", f_name);
            cmd.Parameters.AddWithValue("Deptname1", f_dept);
            cmd.Parameters.AddWithValue("Username1", f_faculty);
            cmd.Parameters.AddWithValue("UserId1", f_user);
            cmd.Parameters.AddWithValue("Userpass1", f_pass);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Delete");

            return "Done";
        }
    }
}