using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace WebApplication1
{
    public partial class view_hostory : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string path = ConfigurationManager.AppSettings["Mark"];
                conn = new SqlConnection(path);
                conn.Open();

                string insert_k = "select * from allotedb;";
                cmd = new SqlCommand(insert_k, conn);

                rdr = cmd.ExecuteReader();

                if(rdr.Read())
                {
                    lblName.Text = rdr["Name"].ToString();
                    lblId.Text = rdr["Id"].ToString();
                    lblDept.Text = rdr["Dept"].ToString();
                    Label1.Text = rdr["Mark"].ToString();
                }
            }
        }
    }
}