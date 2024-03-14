using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}