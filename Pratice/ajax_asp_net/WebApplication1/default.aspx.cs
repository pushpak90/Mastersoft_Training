using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using DataAccess;
using Newtonsoft.Json;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        
        UserDA da = new UserDA();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_dept();
            }
        }

        protected void bind_dept()
        {
            controller objHelp = new controller();
            DataSet ds = new DataSet();
            ds = objHelp.drop_down();
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                ddlDeg.DataSource = ds.Tables[0];
                ddlDeg.DataValueField = "Degreeid";
                ddlDeg.DataTextField = "DegreeName";
                ddlDeg.DataBind();
                ddlDeg.Items.Insert(0, "Select");
            }
            else
            {
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<var_S> bindtable()
        {
            controller cs = new controller();
            DataSet ds = new DataSet();
            List<var_S> btable = new List<var_S>();

            try
            {
                ds = cs.control_bind_table();

                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    btable = (from DataRow dr in ds.Tables[0].Rows
                                    select new var_S
                                    {
                                        name = dr[0].ToString(),
                                        email = dr[1].ToString(),
                                        college = dr[2].ToString(),
                                        branch = dr[3].ToString(),
                                        degree = dr[4].ToString(),
                                        branch_ddl = dr[5].ToString(),
                                    }).ToList();
                }

            }
            catch(Exception ex)
            {
                string error = ex.Message;
            }
            return btable;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<var_S> bind_branch(string deg)
        {
            controller col = new controller();
            DataSet ds = new DataSet();
            List<var_S> bind_ddl_branch = new List<var_S>();
            var_S ob = new var_S();
            string deg_num = deg;
            try
            {
                 ds = col.drop_down_brach(deg_num);

                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    bind_ddl_branch = (from DataRow dr in ds.Tables[0].Rows
                                    select new var_S
                                    {
                                        ddl_branch_no = Convert.ToString(dr[0]),
                                        ddl_branch = Convert.ToString(dr[2])

                                    }).ToList();
                }


            }
            catch
            {

            }
            return bind_ddl_branch;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static int SaveModule(string name, string email, string college, string branch, int ddl_deg, string ddl_branch)
        {
            try
             {
                var_S bo = new var_S();
                controller objHelp = new controller();
                //DataSet ds = new DataSet();

                //List<HelpMasterEntity.HelpMoule> HelpModuleList1 = new List<HelpMasterEntity.HelpMoule>();

                //string json = JsonConvert.SerializeObject(TextHelpModuleTable);
                //DataTable HelpModuleList = JsonConvert.DeserializeObject<DataTable>(json);

                bo.name = name;
                bo.email = email;
                bo.college = college;
                bo.branch = branch;
                bo.i_ddl_deg_no = ddl_deg;
                bo.i_ddl_branch_no = ddl_branch;


                //ds = objHelp.Insert_Info(HelpModuleList);
                objHelp.Insert_Info(bo);
                //Label1.Text = "Hello world";
                //la = ds.ToString();
                return 1;
            }
            catch (Exception ex)
            {
                
                return 0;
            }

        }
    }
}