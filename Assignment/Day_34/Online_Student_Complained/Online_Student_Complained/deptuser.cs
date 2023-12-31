using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Drawing;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace Online_Student_Complained
{
    public class deptuser
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlDataReader rdr;
        public SqlDataAdapter sda;
        public DataTable dt;
        public string p_colName, p_collegeCode, p_dept;

        public string page(string f_colname, string f_colcode)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            // apply command for College Name
            string k = "select Deptname from Deptdb where Collegename = @Collegename1 AND Collegecode = @Collegecode1";
            cmd = new SqlCommand(k, conn);
            cmd.Parameters.AddWithValue("Collegename1", f_colname);
            cmd.Parameters.AddWithValue("Collegecode1", f_colcode);

            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            return "Done";
        }

        public string insert_user(string f_name, string f_code, string f_dept, string f_faculty, string f_id, 
            string f_pass, string d_date)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string check_id = "select UserId from Depuser where UserId = @UserId1";
            cmd = new SqlCommand(check_id, conn);
            cmd.Parameters.AddWithValue("UserId1",f_id);
            rdr = cmd.ExecuteReader();

            if(rdr.Read())
            {
                if (rdr["UserId"].ToString() == f_id)
                {
                    HttpContext.Current.Response.Write("Duplicate User ID");
                }
            }
            else
            {
                string path1 = ConfigurationManager.AppSettings["collegeDB"];
                conn = new SqlConnection(path1);
                conn.Open();

                //store procedure
                cmd = new SqlCommand("insert_user", conn);

                // used command type property
                cmd.CommandType = CommandType.StoredProcedure;

                // parameter
                cmd.Parameters.AddWithValue("Collegename1", f_name);
                cmd.Parameters.AddWithValue("Collegecode1", f_code);
                cmd.Parameters.AddWithValue("Deptname1", f_dept);
                cmd.Parameters.AddWithValue("Username1", f_faculty);
                cmd.Parameters.AddWithValue("Userid1", f_id);
                cmd.Parameters.AddWithValue("Userpass1", f_pass);
                cmd.Parameters.AddWithValue("D_date1", f_dept);

                cmd.ExecuteNonQuery();
                HttpContext.Current.Response.Write("<script>alert ('Data inserted')</script>");
            }
            rdr.Close();
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

        public string delete_user(string f_id)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("delete_user", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("UserId1", f_id);
            
            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Delete");

            return "Done";
        }
    }
}