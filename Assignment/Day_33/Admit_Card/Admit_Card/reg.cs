using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Admit_Card
{
    public class reg
    {
        SqlConnection con;
        SqlCommand cmd;
        public SqlDataReader dr;

        public string data_input(string f_App, string f_Enro, string f_Name, string f_DOB, 
            string f_Ncast, string f_Gender, string f_Dateexam, string f_ETime, 
            string f_Examcenter, string f_Photo, string f_Signa)
        {
            //SQL connection
            string path = ConfigurationManager.AppSettings["adDB"];
            con = new SqlConnection(path);
            con.Open();
            //SQL query
            string insert_q = "INSERT INTO Reg (Application, Enrollment, Name, DOB, NCast, Gender, DateExam, ETime, Examcenter, Photo, Signa) values (@Application1, @Enrollment1, @Name1, @DOB1, @NCast1, @Gender1, @DateExam1, @ETime1, @Examcenter1, @Photo1, @Signa1);";
            cmd = new SqlCommand(insert_q, con);
            cmd.Parameters.AddWithValue("Application1", f_App);
            cmd.Parameters.AddWithValue("Enrollment1", f_Enro);
            cmd.Parameters.AddWithValue("Name1", f_Name);
            cmd.Parameters.AddWithValue("DOB1", f_DOB);
            cmd.Parameters.AddWithValue("NCast1", f_Ncast);
            cmd.Parameters.AddWithValue("Gender1", f_Gender);
            cmd.Parameters.AddWithValue("DateExam1", f_Dateexam);
            cmd.Parameters.AddWithValue("ETime1", f_ETime);
            cmd.Parameters.AddWithValue("Examcenter1", f_Examcenter);
            cmd.Parameters.AddWithValue("Photo1", f_Photo);
            cmd.Parameters.AddWithValue("Signa1", f_Signa);

            cmd.ExecuteNonQuery();
            HttpContext.Current.Response.Write("Data Insert");
            return "Done";
        }

        public string show_data()
        {
            //SQL connection
            string path = ConfigurationManager.AppSettings["adDB"];
            con = new SqlConnection(path);
            con.Open();
            //SQL query
            string select_q = "SELECT * FROM Reg";
            cmd = new SqlCommand(select_q, con);
            dr = cmd.ExecuteReader();

            return "Grid";
        }
    }
}