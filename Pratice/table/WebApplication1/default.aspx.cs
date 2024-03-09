using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string Submit(string firstName, string lastName)
        {
            UserBO bo = new UserBO();
            UserBL bl = new UserBL();
            string msg = string.Empty;
            try
            {
                bo.firstName = firstName;
                bo.lastName = lastName;

                msg = bl.controllerSubmit(bo);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<UserBO> bindTable()
        {
            string msg = string.Empty;
            List<UserBO> li = new List<UserBO>();
            UserBL bl = new UserBL();
            try
            {
                DataSet ds = new DataSet();
                ds = bl.controllerBindTable();

                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    li = (from DataRow dr in ds.Tables[0].Rows
                          select new UserBO
                          {
                              firstName = dr[0].ToString(),
                              lastName = dr[1].ToString(),
                          }).ToList();
                }

                msg = "Table";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return li;
        }
    }
}