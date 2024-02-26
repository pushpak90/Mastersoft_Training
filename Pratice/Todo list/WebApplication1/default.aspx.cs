using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using BusinessLogic;
using System.Data;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static int SaveTodo(string name)
        {
            int result = 0;
            try
            {
                UserBO bo = new UserBO();
                UserBL bl = new UserBL();

                bo.todolist = name;

                result = bl.insert_data(bo);
            }
            catch(Exception ex)
            {
                string error_msg = ex.Message;
            }
            return result;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<UserBO> printTodo(string Id)
        {
            DataSet ds = null;   
            List<UserBO> li = new List<UserBO>();
            try
            {
                UserBL bl = new UserBL();
                ds = bl.show_todo();

                if(ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    li = (from DataRow dr in ds.Tables[0].Rows select new UserBO {
                        todo_msg = dr[1].ToString(),
                        status = int.Parse(dr[2].ToString()),
                    }).ToList();
                }

            }
            catch (Exception ex)
            {
                string error_msg = ex.Message;
            }

            return li;
        }
    }
}