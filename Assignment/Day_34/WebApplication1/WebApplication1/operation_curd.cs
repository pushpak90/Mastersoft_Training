using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public class operation_curd
    {
        SqlConnection con;
        SqlCommand com;
        public SqlDataReader dr;

        public string insert_q(int f_roll, string f_name, string f_city)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();

            //query
            com = new SqlCommand("curd_op", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", f_roll);
            com.Parameters.AddWithValue("Name1", f_name);
            com.Parameters.AddWithValue("City1", f_city);

            com.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Insert");
            return "Insert";
        }

        public string find_q(int f_roll, string f_name, string f_city)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();

            //query
            com = new SqlCommand("Find_curd1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", f_roll);
            dr = com.ExecuteReader();
            
            return "Done";
        }

        public string show_q()
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();

            //query
            com = new SqlCommand("show_class", con);
            com.CommandType = CommandType.StoredProcedure;
            dr = com.ExecuteReader();
            return "Done";
        }
        public string update_q(int f_roll, string f_name, string f_city)
        {

            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();
            //query
            com = new SqlCommand("Update_curd1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", f_roll);
            com.Parameters.AddWithValue("Name1", f_name);
            com.Parameters.AddWithValue("City1", f_city);

            com.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Update");
            return "Done";
        }
        public string delete_q(int f_roll)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();
            //query
            com = new SqlCommand("Delete_curd1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", f_roll);
            com.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Delete");
            return "Done";
        }
    }
}