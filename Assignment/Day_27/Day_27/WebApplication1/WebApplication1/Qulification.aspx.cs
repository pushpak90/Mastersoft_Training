using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Qulification : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtId.Text = (string)Session["g_id"];
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BioDB"];
            con = new SqlConnection(path);
            con.Open();

            string insert_q = "INSERT INTO EduInfoDB (Id, Degree, Ugname, Pgname, YOP) values (@Id1, @Degree1, @Ugname1, @Pgname1, @YOP1);";
            com = new SqlCommand(insert_q, con);

            com.Parameters.AddWithValue("@Id1",(string)Session["g_id"]);
            com.Parameters.AddWithValue("@Degree1", ddlDegree.SelectedValue);
            com.Parameters.AddWithValue("@Ugname1",txtUG.Text);
            com.Parameters.AddWithValue("@Pgname1", txtPG.Text);
            com.Parameters.AddWithValue("@YOP1", txtYear.Text);

            com.ExecuteNonQuery();

            Response.Write("Data Inserted");

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("experience.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BioDB"];
            con = new SqlConnection(path);
            con.Open();

            string update_q = "UPDATE EduInfoDB SET Degree = @Degree1, Ugname = @Ugname1, Pgname = @Pgname, YOP = @YOP1 WHERE Id = @Id1;";
            com = new SqlCommand(update_q, con);

            com.Parameters.AddWithValue("@Id1", (string)Session["g_id"]);
            com.Parameters.AddWithValue("@Degree1", ddlDegree.SelectedValue);
            com.Parameters.AddWithValue("@Ugname1", txtUG.Text);
            com.Parameters.AddWithValue("@Pgname1", txtPG.Text);
            com.Parameters.AddWithValue("@YOP1", txtYear.Text);

            com.ExecuteNonQuery();

            Response.Write("Data Inserted");
        }
    }
}