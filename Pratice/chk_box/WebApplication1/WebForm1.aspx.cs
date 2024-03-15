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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            controller cs = new controller();
            DropDownList1.DataSource = cs.DROP();
            DropDownList1.DataTextField = "BranchName";
            DropDownList1.DataValueField = "BranchID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string selectedValues = "";
            string ddl_value = DropDownList1.SelectedValue;
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    selectedValues += item.Value + ",";
                }
            }

            if (!string.IsNullOrEmpty(selectedValues))
            {
                selectedValues = selectedValues.TrimEnd(',');
            }

            Response.Write(selectedValues);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<entity> Excel()
        {
            List<entity> li = new List<entity>();
            DataSet dataSet = new DataSet();
            string msg = string.Empty;
            try
            {
                controller cs = new controller();
                dataSet = cs.table();


                if(dataSet != null || dataSet.Tables[0].Rows.Count > 1)
                {
                    li = (from DataRow dr in dataSet.Tables[0].Rows
                          select new entity
                          {
                              Column1 = dr[0].ToString(),
                              Column2  = dr[1].ToString(),
                              Column3 = dr[2].ToString(),
                              Column4 = dr[4].ToString(),
                              Column5 = dr[5].ToString(),
                              Column6 = dr[6].ToString(),
                              Column7 = dr[7].ToString(),
                              Column8 = dr[8].ToString(),
                              Column9 = dr[9].ToString(),
                              Column10 = dr[10].ToString(),
                          }).ToList();
                }

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return li;
        }
    }
}