using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
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
    }
}