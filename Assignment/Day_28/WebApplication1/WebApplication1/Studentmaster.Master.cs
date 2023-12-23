using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Studentmaster : System.Web.UI.MasterPage
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string path = ConfigurationManager.AppSettings["Mark"];
                _connection = new SqlConnection(path);
                _connection.Open();
                string select_q = "Select * from StudentRegDb where Email = @Email1;";
                _command = new SqlCommand(select_q, _connection);
                _command.Parameters.AddWithValue("@Email1", (string)Session["s_email"]);

                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    
                    lblName.Text = _reader["Name"].ToString();
                    lblDept.Text = _reader["Dept"].ToString();
                }
                else
                {
                    Response.Write("Record not found");
                }
                _reader.Close();
            }
        }
    }
}