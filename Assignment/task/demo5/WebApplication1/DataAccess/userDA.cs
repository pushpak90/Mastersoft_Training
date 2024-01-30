using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class userDA
    {
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-5O2IMF80;Initial Catalog=happy;Integrated Security=True");
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["emp"]);
        public string inputdata(userBO ob)
        {
            con.Open();

            SqlCommand com = new SqlCommand("input_data_m", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Id1", ob.Id);
            com.Parameters.AddWithValue("Name1", ob.Name);
            com.Parameters.AddWithValue("Email1", ob.Email);
            com.Parameters.AddWithValue("Phone1", ob.Phone);
            com.Parameters.AddWithValue("Pic1", ob.pic);
            com.Parameters.AddWithValue("Dob1", ob.DOB);
            com.Parameters.AddWithValue("Degree1", ob.Degree);
            com.Parameters.AddWithValue("Gender1", ob.Gender);

            // Add output parameter
            SqlParameter outputParam = new SqlParameter("@OutputMessage", SqlDbType.NVarChar, 255);
            outputParam.Direction = ParameterDirection.Output;
            com.Parameters.Add(outputParam);

            com.ExecuteNonQuery();

            string outmessage = com.Parameters["@OutputMessage"].Value.ToString();

            return outmessage;
        }

        public object show_dd()
        {
            con.Open();

            SqlCommand com = new SqlCommand("show_dept", con);
            com.CommandType = CommandType.StoredProcedure;
            //SqlCommand com = new SqlCommand("SELECT * FROM Dept",con);

            SqlDataReader dr = com.ExecuteReader();

            return dr;
        }

        public object show_list()
        {
            con.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM master_page", con);
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(ds);

            //SqlDataReader dr = com.ExecuteReader();

            return ds;
            
        }

        public string fetch_data(userBO bo)
        {
            con.Open();
            SqlCommand com = new SqlCommand("update_user", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Id1",bo.Id);

            SqlDataReader dr = com.ExecuteReader();

            if(dr.Read())
            {
                bo.Name = dr["Name"].ToString();
                bo.Email = dr["Email"].ToString();
                bo.Phone = dr["Phone"].ToString() ;
                bo.DOB = dr["DOB"].ToString();
                bo.Degree = dr["Degree"].ToString();
                bo.Gender = dr["Gender"].ToString();
                bo.pic = dr["Pic"].ToString();
            }

            return "Done";
        }


    }
}
