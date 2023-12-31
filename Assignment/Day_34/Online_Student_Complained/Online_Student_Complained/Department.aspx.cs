using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dept d1 = new dept();
            d1.read((string)Session["s_email"], (string)Session["s_pass"]);
            txtCode.Text = d1.p_collegeCode;
            txtCollegename.Text = d1.p_colName;
            Session["s_colname"] = d1.p_colName;
            Session["s_colcode"] = d1.p_collegeCode;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            dept d1 = new dept();
            d1.insert_dept(txtCode.Text, txtCollegename.Text, txtDept.Text);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            dept d1 = new dept();
            d1.show_grid(txtCollegename.Text, txtCode.Text);
            GridView1.DataSource = d1.rdr;
            GridView1.DataBind();
            d1.rdr.Close();
            btnDelete.Visible = true;
        }
    }
}