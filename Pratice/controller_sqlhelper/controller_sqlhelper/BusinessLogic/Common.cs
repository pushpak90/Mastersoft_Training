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

        public void getddldate(DropDownList ddlList, string tablename, string col_1, string col_2, string where, string order)
        {
            try
            {
                SQLHelper sqlhelper = new SQLHelper("Data Source=LAPTOP-5O2IMF80;Initial Catalog=SQLHELPER;Integrated Security=True;Encrypt=False");
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@P_TABLE_NAME", tablename);
                para[1] = new SqlParameter("@P_COL_NAME_1", col_1);
                para[2] = new SqlParameter("@P_COL_NAME_2", col_2);
                
                if (!where.Equals(string.Empty))
                {
                    para[3] = new SqlParameter("@P_WHERE", where);
                }
                else
                {
                    para[3] = new SqlParameter("@P_WHERE", DBNull.Value);
                }

                if(!order.Equals(string.Empty))
                {
                    para[4] = new SqlParameter("@P_ORDER", order);
                }
                else
                {
                    para[4] = new SqlParameter("@P_ORDER", DBNull.Value);
                }

                DataSet ds = null;

                ds = sqlhelper.ExecuteDataSetDep("All_Drop_Down_SP", para);

                ddlList.Items.Clear();
                ddlList.Items.Add("Please Select");
                ddlList.SelectedItem.Value = "0";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlList.DataSource = ds;
                    ddlList.DataValueField = ds.Tables[0].Columns[0].ToString();
                    ddlList.DataTextField = ds.Tables[0].Columns[1].ToString();
                    ddlList.DataBind();
                    ddlList.SelectedIndex = 0;
                }

            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
        }
    }
}
