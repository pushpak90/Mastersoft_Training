using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Drawing;
namespace Online_Student_Complained
{
    public partial class Report : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_dept();
            }
        }

        protected void ddl_dept()
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            // apply command for College Name
            string k = "select Deptname from Deptdb";
            cmd = new SqlCommand(k, conn);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddldeptdrop.DataSource = dt;
            ddldeptdrop.DataBind();
            ddldeptdrop.DataValueField = "Deptname";
            ddldeptdrop.DataBind();
            ddldeptdrop.Items.Insert(0, "Select College Name");

        }
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            Label lblc = (Label)r1.FindControl("lblcomplain");
            Label lblname = (Label)r1.FindControl("lblSname");
            Label lemail = (Label)r1.FindControl("lblEmail");
            Label lDept = (Label)r1.FindControl("lblDept");
            DropDownList ddl = (DropDownList)r1.FindControl("ddlResolve");
            DropDownList ddl2 = (DropDownList)r1.FindControl("ddlStatus");


            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string query = "UPDATE complaintdb SET Resolveby =@r1 , C_Status = @pr WHERE Sname = @Sname1 AND Email = @Email1 AND Branch = @Branch1 AND Complainto= @Complainto;";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("r1", ddl.SelectedValue);
            cmd.Parameters.AddWithValue("pr", ddl2.SelectedValue);
            cmd.Parameters.AddWithValue("Sname1", lblname.Text);
            cmd.Parameters.AddWithValue("Email1", lemail.Text);
            cmd.Parameters.AddWithValue("Branch1", lDept.Text);
            cmd.Parameters.AddWithValue("Complainto", lblc.Text);

            cmd.ExecuteNonQuery();
            Response.Redirect("Report.aspx");

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            Label lblc = (Label)r1.FindControl("lblcomplain");
            Label lblname = (Label)r1.FindControl("lblSname");
            Label lemail = (Label)r1.FindControl("lblEmail");
            Label lDept = (Label)r1.FindControl("lblDept");
            DropDownList ddl = (DropDownList)r1.FindControl("ddlResolve");
            DropDownList ddl2 = (DropDownList)r1.FindControl("ddlStatus");


            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string query = "DELETE FROM complaintdb WHERE  Sname = @Sname1 AND Email = @Email1 AND Branch = @Branch1 AND Complainto= @Complainto;";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("r1", ddl.SelectedValue);
            cmd.Parameters.AddWithValue("pr", ddl2.SelectedValue);
            cmd.Parameters.AddWithValue("Sname1", lblname.Text);
            cmd.Parameters.AddWithValue("Email1", lemail.Text);
            cmd.Parameters.AddWithValue("Branch1", lDept.Text);
            cmd.Parameters.AddWithValue("Complainto", lblc.Text);

            cmd.ExecuteNonQuery();
            Response.Write("Report.aspx");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string find_dept = "select collegeregdb.Collegecode, complaintdb.Sname, complaintdb.Email, complaintdb.Branch, complaintdb.Complainto, complaintdb.msg, complaintdb.Resolveby, complaintdb.C_Status from collegeregdb right join  complaintdb on  collegeregdb.Collegename = complaintdb.Collegename where complaintdb.Branch = @para1;";
            cmd = new SqlCommand(find_dept, conn);
            cmd.Parameters.AddWithValue("para1", ddldeptdrop.SelectedValue);

            rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;

            GridView1.DataBind();

            rdr.Close();

        }

        protected void btnFindAll_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string query = "select collegeregdb.Collegecode, complaintdb.Sname, complaintdb.Email, complaintdb.Branch, complaintdb.Complainto, complaintdb.msg, complaintdb.Resolveby, complaintdb.C_Status from collegeregdb right join  complaintdb on  collegeregdb.Collegename = complaintdb.Collegename";
            cmd = new SqlCommand(query, conn);

            rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;

            GridView1.DataBind();

            rdr.Close();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                string path = ConfigurationManager.AppSettings["collegeDB"];
                conn = new SqlConnection(path);
                conn.Open();

                DropDownList ddlresolve = (DropDownList)e.Row.FindControl("ddlResolve");

                string query = "Select Username from Depuser";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                ddlresolve.DataSource = dt;
                ddlresolve.DataTextField = "Username";
                ddlresolve.DataBind();

                ddlresolve.Items.Insert(0,"Select Department User Name");
            }
        }
    }
}