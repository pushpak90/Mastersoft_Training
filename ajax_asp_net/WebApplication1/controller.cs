using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class controller
    {
        public DataSet drop_down_brach(string deg)
        {
            sqlhelper objSQLHelper = new sqlhelper("Data Source=LAPTOP-5O2IMF80;Initial Catalog=Machine_Test;Integrated Security=True");
            DataSet ds = new DataSet();

            string deg_id = deg;
            
            ds = objSQLHelper.dll_drop_down("ddl_b", deg_id);

            return ds;
        }

        public DataSet drop_down()
        {
            sqlhelper objSQLHelper = new sqlhelper("Data Source=LAPTOP-5O2IMF80;Initial Catalog=Machine_Test;Integrated Security=True");
            DataSet ds = new DataSet();

            ds = objSQLHelper.dll_drop_down("SELECT * FROM Degree","");

            return ds;
        }

        public int Insert_Info(var_S ob)
        {
            //DataSet ds = new DataSet();
            try
            {
                sqlhelper objSQLHelper = new sqlhelper("Data Source=LAPTOP-5O2IMF80;Initial Catalog=happy;Integrated Security=True;Encrypt=False");
                SqlParameter[] objPar = null;
                {
                    objPar = new SqlParameter[6];
                    objPar[0] = new SqlParameter("@Name1", ob.name);
                    objPar[1] = new SqlParameter("@Email1", ob.email);
                    objPar[2] = new SqlParameter("@College1", ob.college);
                    objPar[3] = new SqlParameter("@Branch1", ob.branch);
                    objPar[4] = new SqlParameter("@Degree2", ob.i_ddl_deg_no); 
                    objPar[5] = new SqlParameter("@Branch2", ob.i_ddl_branch_no);
                };

                objSQLHelper.ExecuteDataSetSP("storetabl01", objPar);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                //throw new IITMSException("IITMS.UAIMS.BusinessLayer.BusinessLogic.CollegeController.Getdetails() --> " + ex.Message + " " + ex.StackTrace);
                
            }
            return 1;
        }
    }
}