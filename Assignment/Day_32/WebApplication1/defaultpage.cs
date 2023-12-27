using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class defaultpage
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;

        public string data_input(int f_id, string f_college, string f_dept)
        {
            
            //connecting data base
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_32\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";
            _connection = new SqlConnection(path);
            _connection.Open();
            //query
            string insert_q = "INSERT INTO Dept(Id, College, Dept) values (@Id1, @College1, @Dept1);";
            _command = new SqlCommand(insert_q, _connection);
            _command.Parameters.AddWithValue("Id1", f_id);
            _command.Parameters.AddWithValue("College1", f_college);
            _command.Parameters.AddWithValue("Dept1", f_dept);

            _command.ExecuteNonQuery();

            HttpContext.Current.Response.Write("Data Inserted");
            return "Done";
        }
    }
}