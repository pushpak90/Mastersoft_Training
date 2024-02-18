using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BusinessObject
{
    public class Common
    {
        public DataSet fill_drop()
        {
            DataSet ds = new DataSet();
            try
            {
                SQLHelper sql = new SQLHelper("Data Source=LAPTOP-5O2IMF80;Initial Catalog=SQLHELPER;Integrated Security=True;Encrypt=False");
                ds = sql.ExecuteDataSet("SELECT * FROM DEG", ds);
            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
            return ds;
        }

        public void getddldate(DropDownList ddlList, string query)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = null;


            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
        }
    }
}
