using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;

namespace controller_sqlhelper
{
    public partial class _default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_DEG();
            }
            
        }
        protected void bind_DEG()
        {
            Common obcom = new Common();
            
            ddlDegree.DataSource = obcom.fill_drop();
            ddlDegree.DataValueField = "D_ID";
            ddlDegree.DataTextField = "DEG_NAME";
            ddlDegree.DataBind();
            ddlDegree.Items.Insert(0, "Please Select");
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<UserBO> bind_Branch(string deg_id)
        {
            List<UserBO> branch = new List<UserBO>();
            try
            {
                Common obcom = new Common();
                DataSet ds = new DataSet();
                List <UserBO> li = new List<UserBO>();
                UserBO bo = new UserBO();
                bo.Deg_num = deg_id;

                ds = obcom.fill_drop();
            }
            catch (Exception ex)
            {
                string error_msg = ex.Message;
            }

            return branch;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static int SaveModule(string FirstName, string LastName, string College, string Mobile)
        {
            int result = 0;
            try
            {
                UserBO bo = new UserBO();
                Common common = new Common();
                
                bo.FirstName = FirstName;
                bo.LastName = LastName;
                bo.College = College;
                bo.Mobile = Mobile;

                //result = common.insert_form(bo);

            }
            catch (Exception ex)
            {
                string error_msg = ex.Message;
            }
            return result;
        }
    }
}