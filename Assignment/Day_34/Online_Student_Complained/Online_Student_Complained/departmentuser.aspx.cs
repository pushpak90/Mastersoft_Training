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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Security.Cryptography;


namespace Online_Student_Complained
{
    public partial class departmentuser : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dept d1 = new dept();
                d1.read((string)Session["s_email"], (string)Session["s_pass"]);
                txtcode.Text = d1.p_collegeCode;
                txtname.Text = d1.p_colName;
                ddl();
                txtDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            }
            
        }

        protected void ddl()
        {
            deptuser du = new deptuser();
            du.page(txtname.Text, txtcode.Text);
            ddlDept.DataSource = du.dt;
            ddlDept.DataValueField = "Deptname";
            ddlDept.DataBind();
            ddlDept.Items.Insert(0, "Select College Name");
            
            //Hiden
            DropDownList1.DataSource = du.dt;
            DropDownList1.DataValueField = "Deptname";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select College Name");

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
            DropDownList1.Visible = true;
            Label1.Visible = true;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            deptuser d2 = new deptuser();
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtcolname = (TextBox)r1.FindControl("txtcolname");
            Label lbldept1 = (Label)r1.FindControl("lblDept");
            TextBox txtFname = (TextBox)r1.FindControl("txtFname");
            TextBox txtId = (TextBox)r1.FindControl("txtId");
            TextBox txtpass = (TextBox)r1.FindControl("txtpass");
            
            d2.update_user(txtcolname.Text, lbldept1.Text, txtFname.Text, txtId.Text, txtpass.Text);
            HttpContext.Current.Response.Redirect("departmentuser.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            deptuser d3 = new deptuser();
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtId = (TextBox)r1.FindControl("txtId");
            d3.delete_user(txtId.Text);
            HttpContext.Current.Response.Redirect("departmentuser.aspx");
        }
    }
}