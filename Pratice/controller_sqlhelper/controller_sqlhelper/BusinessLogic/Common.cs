using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
using System.Web.UI.WebControls;

namespace BusinessObject
{
    public class Common
    {
        public void fill_drop()
        {
            DataSet ds = new DataSet();
            ds = null;

            try
            {
                SQLHelper sql = new SQLHelper();
                ds = sql.Bind_Drop_down("bind_drop");
            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
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
