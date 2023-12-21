using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.EnterpriseServices;
using System.Drawing;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class objective : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
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
            conn = new SqlConnection(path);
            conn.Open();

            string insert_q = "INSERT INTO Obj (Id, obj) VALUES (@Id1, @Obj1)";
            cmd = new SqlCommand(insert_q, conn);
            cmd.Parameters.AddWithValue("@Id1", (string)Session["g_id"]);
            cmd.Parameters.AddWithValue("@Obj1", txtObj.Text);

            cmd.ExecuteNonQuery();

            Response.Write("Data Inserted");
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Response.Redirect("finial.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BioDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string insert_q = "UPDATE Obj SET  obj = @obj1 WHERE Id = @Id1";
            cmd = new SqlCommand(insert_q, conn);
            cmd.Parameters.AddWithValue("@Id1", (string)Session["g_id"]);
            cmd.Parameters.AddWithValue("@Obj1", txtObj.Text);

            cmd.ExecuteNonQuery();

            Response.Write("Data Updated");
        }
    }
}