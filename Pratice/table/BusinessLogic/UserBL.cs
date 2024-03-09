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
    public class UserBL
    {

        public string controllerSubmit(UserBO bo)
        {
            string msg = string.Empty;
            UserDA da = new UserDA("Data Source=LAPTOP-5O2IMF80;Initial Catalog=SQLHELPER;Integrated Security=True;Encrypt=False");
            try
            {
                SqlParameter[] para = null;
                {
                    para = new SqlParameter[2];
                    para[0] = new SqlParameter("@P_FIRSTNAME", bo.firstName);
                    para[1] = new SqlParameter("@P_LASTNAME", bo.lastName);
                }
                msg = da.ExecuteNonQuerySP("storeData", para);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }

    }
}
