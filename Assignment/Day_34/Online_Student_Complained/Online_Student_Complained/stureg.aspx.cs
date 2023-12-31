using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class stureg : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl();
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        protected void ddl()
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            con = new SqlConnection(path);
            con.Open();

            // apply command for College Name
            string k = "select Collegename from  collegeregdb";
            com = new SqlCommand(k, con);
            
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddlcol.DataSource = dt;
            ddlcol.DataBind();
            ddlcol.DataValueField = "Collegename";
            ddlcol.DataBind();
            ddlcol.Items.Insert(0, "Select College Name");

            // apply command for College Name
            string q = "select Deptname from  Deptdb";
            com = new SqlCommand(q, con);

            SqlDataAdapter sda1 = new SqlDataAdapter(com);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            ddlb.DataSource = dt1;
            ddlb.DataBind();
            ddlb.DataValueField = "Deptname";
            ddlb.DataBind();
            ddlb.Items.Insert(0, "Select Department");


        }
        /*
        protected void ddl2()
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            con = new SqlConnection(path);
            con.Open();

            // apply command
            string k = "select Deptname from  Deptdb";
            com = new SqlCommand(k, con);
            dr = com.ExecuteReader();

            ddlb.DataSource = dr;
            ddlb.DataTextField = "Deptname";
            ddlb.DataBind();
            ddlb.Items.Insert(0, "SELECT");

            dr.Close();
        }
        */
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            student_reg reg = new student_reg();
            reg.insert_q(ddlcol.SelectedItem.Value, txtname.Text, ddlb.SelectedValue, txtEmail.Text, txtMobile.Text, txtSem.Text, txtpassword.Text, txtDate.Text);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("stulogin.aspx");
        }
    }
}