using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Admit_Card
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;
        public SqlDataReader dr;
        public string admit_card(string f_enroll)
        {
            //SQL connection
            string path = ConfigurationManager.AppSettings["adDB"];
            con = new SqlConnection(path);
            con.Open();
            //SQL query
            string select_q = "SELECT * FROM Reg WHERE Enrollment = @Enrollment1";
            cmd = new SqlCommand(select_q, con);
            cmd.Parameters.AddWithValue("Enrollment1", f_enroll);
            dr = cmd.ExecuteReader();
            return "Done";
        }
    }
}