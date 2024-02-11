using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class sqlhelper
    {
        private string _constr = string.Empty;
        public sqlhelper(string connectionstring)
        {
            _constr = connectionstring;
        }

        public DataSet dll_drop_down(string query, string para)
        {
            DataSet ds = new DataSet();
            SqlConnection cnn = new SqlConnection(_constr);

            SqlCommand cmd = new SqlCommand(query, cnn);

            if (query.StartsWith("SELECT") | query.StartsWith("select") | query.StartsWith("INSERT") | query.StartsWith("insert") | query.StartsWith("UPDATE") | query.StartsWith("update") | query.StartsWith("DELETE") | query.StartsWith("delete"))
                cmd.CommandType = CommandType.Text;
            else
                cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            cnn.Open();

            cmd.Parameters.AddWithValue("@deId", para);

            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public int ExecuteDataSetSP(String query, SqlParameter[] parameters)
        {
            
            try
            {
                SqlConnection cnn = new SqlConnection(_constr);
                
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (query.StartsWith("SELECT") | query.StartsWith("select") | query.StartsWith("INSERT") | query.StartsWith("insert") | query.StartsWith("UPDATE") | query.StartsWith("update") | query.StartsWith("DELETE") | query.StartsWith("delete"))
                    cmd.CommandType = CommandType.Text;
                else
                    cmd.CommandType = CommandType.StoredProcedure;

                int i;
                for (i = 0; i < parameters.Length; i++)
                    cmd.Parameters.Add(parameters[i]);
                cnn.Open();
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                //throw new IITMSException("IITMS.SQLServer.SQLDAL.SQLHelper.ExecuteDataSetSP-> " + ex.ToString());
            }
            return 1;
        }
    }
}