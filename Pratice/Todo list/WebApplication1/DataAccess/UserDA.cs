using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class UserDA
    {
        private string _connection;
        public UserDA(string connection)
        {
            _connection = connection;
        }

        public int ExecuteNonQuerySP(string query, SqlParameter[] para)
        {
            int result = 0;
            try
            {
                SqlConnection con = new SqlConnection(_connection);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if(query.StartsWith("insert") || query.StartsWith("INSERT"))
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

                result = cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }

            return result;
        }

        public DataSet ExecuteQuerySP(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(_connection);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if(query.StartsWith("SELECT") || query.StartsWith("select"))
                {
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                string error_msg = ex.Message;
            }
            return ds;
        }
    }
}
