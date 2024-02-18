using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class SQLHelper
    {
        private string _connection = string.Empty;
        public SQLHelper(string connectionstring)
        {
            _connection = connectionstring;
        }

        public int ExecuteNonQuerySP(string query, SqlParameter[] para)
        {
            int result = 0;
            try
            {
                SqlConnection con = new SqlConnection(_connection);
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
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error_msg = ex.Message;
            }
            return result;
        }

        public DataSet ExecuteDataSet(string query,DataSet ds) 
        {
            try
            {
                SqlConnection con = new SqlConnection(_connection);
                SqlCommand cmd = new SqlCommand(query, con);

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

        public DataSet ExecuteDataSetDep(string query, SqlParameter[] para)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(_connection);
                SqlCommand cmd = new SqlCommand(query, con);

                if (query.StartsWith("SELECT") || query.StartsWith("select"))
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
