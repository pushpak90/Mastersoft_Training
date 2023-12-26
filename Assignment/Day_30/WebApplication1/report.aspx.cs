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
    public partial class report_aspx : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string path = ConfigurationManager.AppSettings["stuDB"];
                conn = new SqlConnection(path);
                conn.Open();


                string select_q = "select * from student WHERE Id=@Id1";
                com = new SqlCommand(select_q, conn);

                com.Parameters.AddWithValue("@Id1", (string)Session["s_id"]);

                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    lblId.Text = (string)Session["s_id"];
                    lblName.Text = dr["Name"].ToString();
                    lblEmail.Text = dr["Email"].ToString();
                    lblMobile.Text = dr["Mobile"].ToString();
                    lblStatus.Text = dr["Status"].ToString();
                    lblPercentage.Text = dr["Percentage"].ToString();
                    lblGrade.Text = dr["Grade"].ToString();
                    lblTotal.Text = dr["Total"].ToString();
                }
                dr.Close();


            }
        }
    }
}