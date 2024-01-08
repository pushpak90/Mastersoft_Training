using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BuinessObject;

namespace DataAccess
{
    public class UserDA
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public int AddVendor(UserOB objob)
        {
            string path = "Data Source=LAPTOP-5O2IMF80;Initial Catalog=Final_ass;Integrated Security=True;Encrypt=False";
            con = new SqlConnection(path);
            con.Open();

            cmd = new SqlCommand("AddVendor", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id1", objob.Id);
            cmd.Parameters.AddWithValue("@Name1", objob.Name);
            cmd.Parameters.AddWithValue("@City1", objob.City);
            cmd.Parameters.AddWithValue("@Address1", objob.Address);
            cmd.Parameters.AddWithValue("@Mobile1", objob.Mobile);
            cmd.Parameters.AddWithValue("@Status1", objob.Status);

            int result = cmd.ExecuteNonQuery();
            

            return result;
        }
    }
}
