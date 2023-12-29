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
    public class dept
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlDataReader rdr;
        public string p_colName, p_collegeCode, p_deptName;
        public string read(string f_email, string f_pass)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("Name_col", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Email1", f_email);
            cmd.Parameters.AddWithValue("Code", f_pass);

            rdr = cmd.ExecuteReader();

            if(rdr.Read())
            {
                p_colName = rdr["Collegename"].ToString();
                p_collegeCode = rdr["Collegecode"].ToString();
            }
            
            rdr.Close();

            return "done";
        }

        public string insert_dept(string f_colCode, string f_colName, string f_deptName)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("dept_input", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Collegename1",f_colName);
            cmd.Parameters.AddWithValue("Collegecode1", f_colCode);
            cmd.Parameters.AddWithValue("Deptname1", f_deptName);
            HttpContext.Current.Session["s_colname"] = f_colName;
            HttpContext.Current.Session["s_colcode"] = f_colCode;
            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("data insert");
            return "Done";
        }

        public string show_grid()
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("show_grid", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            rdr = cmd.ExecuteReader();

            return "Done";
        }
    }
}