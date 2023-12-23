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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                
                string path = ConfigurationManager.AppSettings["Mark"];
                _connection = new SqlConnection(path);
                _connection.Open();

                string ss_q = "select * From deptlogindb where fac_id = @fac_id1";
                _command = new SqlCommand(ss_q, _connection);
                _command.Parameters.AddWithValue("@fac_id1", (string)Session["s_email"]);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    lblName.Text = _reader["fac_id"].ToString();
                    lblDept.Text = _reader["dept"].ToString();
                }
                
            }
            
        }
    }
}