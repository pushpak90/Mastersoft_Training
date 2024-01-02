using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Online_Student_Complained
{
    public partial class Student : System.Web.UI.MasterPage
    {
        SqlConnection conn;
        SqlCommand cmd;
        public SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblemail.Text = (string)Session["s_Email"];
            news((string)Session["s_college"]);
        }

        protected void news(string f_col_name)
        {
            string path = ConfigurationManager.AppSettings["collegeDB"];
            conn = new SqlConnection(path);
            conn.Open();

            string news_q = "SELECT * FROM news WHERE Collegename = @Collegename1";
            cmd = new SqlCommand(news_q, conn);
            cmd.Parameters.AddWithValue("Collegename1", f_col_name);
            reader = cmd.ExecuteReader();

            Repeater1.DataSource = reader;
            Repeater1.DataBind();

            reader.Close();

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("stulogin.aspx");
        }
    }
}