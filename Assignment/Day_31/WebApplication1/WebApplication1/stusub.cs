using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class stusub
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public string input_data(string f_id, string f_Name, string f_email, string f_dept, string f_password)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            con = new SqlConnection(path);
            con.Open();

            string auto_create = "select count(Studentid)+1 from StudentRegDb";
            cmd = new SqlCommand(auto_create, con);


            //string name = (string)HttpContext.Current.Session["id"];

            //HttpContext.Current.Session["g_id"] = "STU-" + DateTime.Now.ToString("yyyy") + ("-") + f_dept + "-00-" + cmd.ExecuteScalar().ToString();
            //f_id = (string)HttpContext.Current.Session["g_id"];

            //string f_id = "STU-" + DateTime.Now.ToString("yyyy") + ("-") + f_dept + "-00-" + cmd.ExecuteScalar().ToString();
            string date_c = DateTime.Now.ToString("dd/MM/yyyy");
            // add query
            string c_command = "insert into StudentRegDb (Studentid , Name, Email,Dept,Password,Date) values (@Studentid1 , @Name1, @Email1,@Dept1,@Password1,@Date1) ";
            cmd = new SqlCommand(c_command, con);

            //parameter
            cmd.Parameters.AddWithValue("Studentid1 ", f_id);
            cmd.Parameters.AddWithValue("Name1 ", f_Name);
            cmd.Parameters.AddWithValue("Email1 ", f_email);
            cmd.Parameters.AddWithValue("Dept1 ", f_dept);
            cmd.Parameters.AddWithValue("Password1 ", f_password);
            cmd.Parameters.AddWithValue("Date1 ", date_c.ToString());



            cmd.ExecuteNonQuery();
            
            return f_id;
        }
    }
}