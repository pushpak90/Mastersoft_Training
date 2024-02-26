using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BusinessLogic
{
    public class UserBL
    {
        private string conn = ConfigurationManager.ConnectionStrings["todo"].ConnectionString;
        public int insert_data(UserBO bo)
        {
            int result = 0;
            try
            {
                UserDA da = new UserDA(conn);

                SqlParameter[] objParams = new SqlParameter[1];
                objParams[0] = new SqlParameter("@P_TODO_MSG", bo.todolist);

                result = da.ExecuteNonQuerySP("STORE_TODO", objParams);
            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
            return result;
        }

        public DataSet show_todo()
        {
            DataSet ds = null;
            try
            {
                UserDA da = new UserDA(conn);
                ds = da.ExecuteQuerySP("SELECT * FROM TODOLIST");
            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
            return ds;
        }
    }
}
