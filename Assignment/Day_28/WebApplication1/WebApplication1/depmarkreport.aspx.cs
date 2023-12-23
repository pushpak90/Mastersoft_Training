using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class depmarkreport : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            conn = new SqlConnection(path);
            conn.Open();

            string ss_q = "select * From allotedb";
            cmd = new SqlCommand(ss_q, conn);

            reader = cmd.ExecuteReader();
            // Connect data control to grid view

            GridView1.DataSource = reader;
            GridView1.DataBind();

            reader.Close();
        }
    }
}