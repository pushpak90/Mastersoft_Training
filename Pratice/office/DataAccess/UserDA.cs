using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public class UserDA
    {
        private string _connectionString;

        public UserDA(string Connection) 
        {
            _connectionString = Connection;
        }

        public DataSet bindddl(string query)
        {
            DataSet ds = new DataSet();
            string msg = string.Empty;
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlCommand cmd = new SqlCommand(query, con);

                if(query.StartsWith("SELECT") || query.StartsWith("select"))
                {
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                con.Open();
                SqlDataAdapter dr = new SqlDataAdapter(cmd);

                dr.Fill(ds);
                
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }

            return ds;
        }

        public string insertSP(string query, SqlParameter[] para)
        {
            string msg = string.Empty;
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlCommand cmd = new SqlCommand(query, con);

                if (query.StartsWith("INSERT") || query.StartsWith("insert"))
                {
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
                //cmd.Parameters.AddRange(para);
                con.Open();
                msg = (cmd.ExecuteNonQuery()).ToString();

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

    }
}
