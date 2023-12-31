using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace Online_Student_Complained
{
    public class newspage
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlDataReader rdr;
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

        public string news_inser(string f_collegeCode, string f_collegeName, string f_newsTitle, string f_message,
            string f_date)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("news_inser", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Collegename1", f_collegeName);
            cmd.Parameters.AddWithValue("Collegecode1", f_collegeCode);
            cmd.Parameters.AddWithValue("Newstitle1", f_newsTitle);
            cmd.Parameters.AddWithValue("n_Message1", f_message);
            cmd.Parameters.AddWithValue("n_Date1", f_date);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Insert");

            return "Done";
        }
        
        public string show_grid()
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string show_news = "SELECT * FROM news";
            cmd = new SqlCommand(show_news, conn);
            rdr = cmd.ExecuteReader();

            return "Done";
        }

        public string edit_grid(string f_colcode, string f_colname, string f_title, string f_message)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("edit_grid", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Collegecode1", f_colcode);
            cmd.Parameters.AddWithValue("Collegename1", f_colname);
            cmd.Parameters.AddWithValue("Newstitle1", f_title);
            cmd.Parameters.AddWithValue("n_Message1", f_message);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Edited");

            return "Done";
        }

        public string del_grid(string f_colcode, string f_colname, string f_title, string f_message)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("del_grid", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Collegecode1", f_colcode);
            cmd.Parameters.AddWithValue("Collegename1", f_colname);
            cmd.Parameters.AddWithValue("Newstitle1", f_title);
            cmd.Parameters.AddWithValue("n_Message1", f_message);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Delete");

            return "Done";
        }

        public string footer_insert(string f_colcode, string f_colname, string f_title, string f_message, string f_date)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            cmd = new SqlCommand("news_inser", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Collegename1", f_colname);
            cmd.Parameters.AddWithValue("Collegecode1", f_colcode);
            cmd.Parameters.AddWithValue("Newstitle1", f_title);
            cmd.Parameters.AddWithValue("n_Message1", f_message);
            cmd.Parameters.AddWithValue("n_Date1", f_date);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Insert");

            return "Done";
        }
    }
}