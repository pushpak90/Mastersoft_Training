using businessLogic;
using businessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindddl();
                bindcheck();
            }
           
        }
        private void bindddl()
        {
            UserBL bl = new UserBL();
            string msg = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                ds = bl.controllerbind();
                DropDownList1.DataSource = ds;
                DropDownList1.DataValueField = "ID_B";
                DropDownList1.DataTextField = "BRANCH_NAME";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "Please Select");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }   
        }


        private void bindcheck()
        {
            UserBL bl = new UserBL();
            string msg = string.Empty;
            try
            {
                DataSet ds = new DataSet();
                ds = bl.controllercheck();
                CheckBoxList1.DataSource = ds;
                CheckBoxList1.DataValueField = "ID_S";
                CheckBoxList1.DataTextField = "SUB_NAME";
                CheckBoxList1.DataBind();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBO bo = new UserBO();
            string msg = string.Empty;
            UserBL bl = new UserBL();
            try
            {
                bo.ddl_id = DropDownList1.SelectedValue;
                foreach (ListItem item in CheckBoxList1.Items)
                {
                    // Check if the item is selected
                    if (item.Selected)
                    {
                        // Concatenate the selected item's value to the string
                        bo.check_id = bo.check_id + item.Value + ",";
                    }
                }

                // Remove the trailing comma if any
                if (!string.IsNullOrEmpty(bo.check_id))
                {
                    bo.check_id = bo.check_id.TrimEnd(',');
                }
                bo.form_date = TextBox1.Text;

                msg = bl.c_insert_data(bo);

                Response.Write(msg);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
        }
    }
}