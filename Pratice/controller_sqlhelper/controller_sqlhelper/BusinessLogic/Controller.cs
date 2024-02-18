using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Controller
    {
        public int insert_form(UserBO bo)
        {
            int result = 0;
            try
            {
                SQLHelper sQLHelper = new SQLHelper("Data Source=LAPTOP-5O2IMF80;Initial Catalog=SQLHELPER;Integrated Security=True;Encrypt=False");
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@P_FIRST_NAME", bo.FirstName);
                para[1] = new SqlParameter("@P_LAST_NAME", bo.LastName);
                para[2] = new SqlParameter("@P_COLLEGE", bo.College);
                para[3] = new SqlParameter("@P_MOBILE", bo.Mobile);

                result = sQLHelper.ExecuteNonQuerySP("SP_INSERT", para);

            }
            catch (Exception ex)
            {
                string error_msg = ex.Message;
            }

            return result;
        }
    }
}
