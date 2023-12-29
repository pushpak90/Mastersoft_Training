using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Online_Student_Complained
{
    public class collreg
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlDataReader reader;

        public string intput_data(string f_collegeName, string f_collegeCode, string f_principal, string f_email,
            string f_mobile, string f_password, string f_date)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();
            
            cmd = new SqlCommand("check_Code", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Code1", f_collegeCode.ToString());
            reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                if (reader["Collegecode"].ToString() == f_collegeCode.ToString())
                {
                    HttpContext.Current.Response.Write("Already Exist");
                }
            }
            else
            {
                string spath = ConfigurationManager.AppSettings["collegeDB"];
                conn = new SqlConnection(spath);
                conn.Open();
                cmd = new SqlCommand("input_data", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cname", f_collegeName);
                cmd.Parameters.AddWithValue("@Ccode", f_collegeCode);
                cmd.Parameters.AddWithValue("@Pri", f_principal);
                cmd.Parameters.AddWithValue("@Email1", f_email);
                cmd.Parameters.AddWithValue("@Mob", f_mobile);
                cmd.Parameters.AddWithValue("@Cpass", f_password);
                cmd.Parameters.AddWithValue("@Cdate", f_date);
                cmd.ExecuteNonQuery();
                HttpContext.Current.Response.Write("data insert");
            }
            reader.Close();
            return "Done";
        }
    }
}