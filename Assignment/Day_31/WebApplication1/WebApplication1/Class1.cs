using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public string p_id, p_name, p_dept;
        public string display(string f_email, string f_password)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            con = new SqlConnection(path);
            con.Open();
            string select_q = "Select * from StudentRegDb where Email = @Email1 AND Password = @Password1;";
            cmd = new SqlCommand(select_q, con);
            cmd.Parameters.AddWithValue("Email1", f_email);
            cmd.Parameters.AddWithValue("Password1", f_password);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                p_id = dr["Studentid"].ToString();
                p_name= dr["Name"].ToString();
                p_dept = dr["Dept"].ToString();
            }
            else
            {
                HttpContext.Current.Response.Write("Record not found");
            }
            dr.Close();
            return "Done";
        }
        public string act(string f_id, string f_name, string f_dept, string f_act, string f_org, string f_date, string f_remark)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            con = new SqlConnection(path);
            con.Open();

            string insert_q = "insert into ActivityDB (ID, Name, Dept, Activity, Org, Dateofactivity, Remark) values (@ID1, @Name1, @Dept1, @Acivity1, @Org1, @Dateofactivity1, @Remark1);";
            cmd = new SqlCommand(@insert_q, con);
            cmd.Parameters.AddWithValue("@ID1 ", f_id);
            cmd.Parameters.AddWithValue("@Name1 ", f_name);
            cmd.Parameters.AddWithValue("@Dept1 ", f_dept);
            cmd.Parameters.AddWithValue("@Acivity1", f_act);
            cmd.Parameters.AddWithValue("@Org1", f_org);
            cmd.Parameters.AddWithValue("@Dateofactivity1 ", f_date);
            cmd.Parameters.AddWithValue("@Remark1 ", f_remark);



            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data insert");
            
            return "Done";
            
        }
    }
}