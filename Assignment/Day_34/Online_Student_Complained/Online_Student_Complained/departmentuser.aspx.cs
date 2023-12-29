using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Online_Student_Complained
{
    public partial class departmentuser : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            deptuser du = new deptuser();
            du.page((string)Session["s_colname"], (string)Session["s_colcode"]);
            txtcode.Text = du.p_collegeCode;
            txtname.Text = du.p_colName;
            ddlDept.Items.Add(du.p_dept);
            txtDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            deptuser d1 = new deptuser();
            d1.insert_user(txtcode.Text, txtname.Text, ddlDept.SelectedValue, txtFaculty.Text, txtUser.Text,
                txtpass.Text, txtDate.Text);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            //Connection 
            string path = ConfigurationManager.AppSettings["collegeDB"];
            con = new SqlConnection(path);
            con.Open();
            //Query
            string select_q = "SELECT * FROM depuser";
            com = new SqlCommand(select_q, con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            com.Connection = con;
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            deptuser d2 = new deptuser();
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtcolname = (TextBox)r1.FindControl("txtcolname");
            TextBox txtDept = (TextBox)r1.FindControl("txtDept");
            TextBox txtFname = (TextBox)r1.FindControl("txtFname");
            TextBox txtpass = (TextBox)r1.FindControl("txtpass");
            TextBox txtId = (TextBox)r1.FindControl("txtId");
            d2.update_user(txtcolname.Text, txtDept.Text, txtFname.Text, txtId.Text, txtpass.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            deptuser d3 = new deptuser();
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtcolname = (TextBox)r1.FindControl("txtcolname");
            TextBox txtDept = (TextBox)r1.FindControl("txtDept");
            TextBox txtFname = (TextBox)r1.FindControl("txtFname");
            TextBox txtpass = (TextBox)r1.FindControl("txtpass");
            TextBox txtId = (TextBox)r1.FindControl("txtId");
            d3.delete_user(txtcolname.Text, txtDept.Text, txtFname.Text, txtId.Text, txtpass.Text);
        }
    }
}