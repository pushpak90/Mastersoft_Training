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


namespace WebApplication1
{
    public partial class det : System.Web.UI.Page
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pushpak\\Desktop\\MasterSoft\\Assignment\\Day_27\\WebApplication1\\WebApplication1\\App_Data\\College.mdf;Integrated Security=True";
            _connection = new SqlConnection(path);
            _connection.Open();

            string ss_q = "select * From Student";
            _command = new SqlCommand(ss_q, _connection);

            _reader = _command.ExecuteReader();
            // Connect data control to grid view

            GridView1.DataSource = _reader;
            GridView1.DataBind();

            _reader.Close();

            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pushpak\\Desktop\\MasterSoft\\Assignment\\Day_27\\WebApplication1\\WebApplication1\\App_Data\\College.mdf;Integrated Security=True";
            _connection = new SqlConnection(path);
            _connection.Open();

            string ss_q = "select * From Student where Name = @Name1;";
            
            _command = new SqlCommand(ss_q, _connection);
            _command.Parameters.AddWithValue("@Name1",txtName.Text);
            _reader = _command.ExecuteReader();
            // Connect data control to grid view

            GridView1.DataSource = _reader;
            GridView1.DataBind();

            _reader.Close();
        }
    }
}