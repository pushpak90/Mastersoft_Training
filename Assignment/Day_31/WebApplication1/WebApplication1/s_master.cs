using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class s_master
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public string c_name, c_dept;

        public void display(string f_email)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            con = new SqlConnection(path);
            con.Open();
            string select_q = "Select * from StudentRegDb where Email = @Email1;";
            cmd = new SqlCommand(select_q, con);
            cmd.Parameters.AddWithValue("@Email1", f_email);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                c_name = dr["Name"].ToString();
                c_dept = dr["Dept"].ToString();
            }
            else
            {
                HttpContext.Current.Response.Write("Record not found");
            }
            dr.Close();
        }
    }
}