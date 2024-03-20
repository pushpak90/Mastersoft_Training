using businessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLogic
{
    public class UserBL
    {
        private string _connection = "Data Source=LAPTOP-5O2IMF80;Initial Catalog=Company;Integrated Security=True;Encrypt=False";
        public DataSet controllerbind()
         {
             DataSet ds = new DataSet();
             string msg = string.Empty;
             UserDA da = new UserDA(_connection);
             try
             {
                 ds = da.bindddl("SELECT ID_B, BRANCH_NAME FROM BRANCH");
             }
             catch (Exception ex)
             {
                 msg = ex.Message;
             }

             return ds;
         }
         public DataSet controllercheck()
         {
             DataSet ds = new DataSet();
             string msg = string.Empty;
             UserDA da = new UserDA(_connection);
             try
             {
                 ds = da.bindddl("SELECT CODE, SUB_NAME FROM SUB");
             }
             catch (Exception ex)
             {
                 msg = ex.Message;
             }

             return ds;
         }

         public string c_insert_data(UserBO bo)
         {
             string msg = string.Empty;
             UserDA da = new UserDA(_connection); 
             try
             {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@P_BRANCHID", bo.ddl_id);
                if(bo.check_id == "" || bo.check_id == "0" || bo.check_id == string.Empty)
                {
                    para[1] = new SqlParameter("@P_SUBID", DBNull.Value);
                }
                else
                {
                    para[1] = new SqlParameter("@P_SUBID", bo.check_id);
                }
                

                para[2] = new SqlParameter("@P_DATE", bo.form_date);
                msg = da.insertSP("Hello_data", para);
             }
             catch(Exception ex)
             {
                 msg = ex.Message;
             }
             return msg;
         }

        public DataSet control_ddl_comb()
        {
            DataSet ds = new DataSet();
            string msg = string.Empty;
            UserDA da = new UserDA(_connection);
            try
            {
                ds = da.bindddl("BIND_DDL");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return ds;
        }

    }
}
