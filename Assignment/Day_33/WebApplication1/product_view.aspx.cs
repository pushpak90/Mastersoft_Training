using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Reflection.Emit;

namespace WebApplication1
{
    public partial class product_view : System.Web.UI.Page
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Text = (string)Session["userprice"];
                //Connection 
                string path = ConfigurationManager.AppSettings["mydb"];
                _connection = new SqlConnection(path);
                _connection.Open();
                //Query
                string select_q = "SELECT * FROM product where Prodname = @prodname1;"; 
                _command = new SqlCommand(select_q, _connection);
                _command.Parameters.AddWithValue("prodname1", (string)Session["name"]);
                _reader = _command.ExecuteReader();

                DataList1.DataSource = _reader;
                DataList1.DataBind();

                _reader.Close();

            }
        }
    }
}