using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDA
    {
        private string _conn;
        public UserDA(string connection) 
        {
            _conn = connection;
        }

        public string ExecuteNonQuerySP(string query, SqlParameter[] para)
        {
            string msg = string.Empty;
            try
            {
                SqlConnection con = new SqlConnection(_conn);
                SqlCommand cmd = new SqlCommand(query, con);
                if (query.StartsWith("insert") || query.StartsWith("INSERT"))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                }
                else
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
                con.Open();
                msg = (cmd.ExecuteNonQuery()).ToString();
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

    }
}
