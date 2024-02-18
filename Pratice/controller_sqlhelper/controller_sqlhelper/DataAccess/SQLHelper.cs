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
        public DataSet Bind_Drop_down(String query)
        {
            DataSet ds = new DataSet();
            ds = null;
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["sqldb"]);
                SqlCommand cmd = new SqlCommand("bind_drop", con);

                if(query.StartsWith("SELECT") | query.StartsWith("select"))
                {
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                
            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
            return ds;
        }
    }
}
