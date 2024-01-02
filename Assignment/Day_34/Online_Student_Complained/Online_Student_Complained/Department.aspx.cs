using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Online_Student_Complained
{
    public partial class Department : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlDataReader rdr;
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            foreach(GridViewRow r1 in GridView1.Rows)
            {
                CheckBox cb = (CheckBox)r1.FindControl("CheckBox1");
                Label lbldd = (Label)r1.FindControl("lbldep");

                if(cb.Checked)
                {
                    string del_q = "DELETE FROM Deptdb WHERE Deptname = @Deptname1";
                    cmd = new SqlCommand(del_q, conn);
                    cmd.Parameters.AddWithValue("Deptname1", lbldd.Text);

                    cmd.ExecuteNonQuery();
                    Response.Write("Deleted");

                }
            }
        }
    }
}