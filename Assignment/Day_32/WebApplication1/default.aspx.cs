using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            defaultpage d = new defaultpage();
            d.data_input(int.Parse(txtId.Text), txtCollege.Text, txtDept.Text);
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //connecting data base
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_32\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";
            _connection = new SqlConnection(path);
            _connection.Open();
            //query
            string select_q = "SELECT DISTINCT Id, College FROM Dept;";
            _command = new SqlCommand(select_q, _connection);

            _reader = _command.ExecuteReader();
            GridView1.DataSource = _reader;
            GridView1.DataBind();

            _reader.Close();
            foreach (GridViewRow row in GridView1.Rows)
            {
                Repeater Repeater1 = (Repeater)row.FindControl("Repeater1");

                string departmentQuery = "SELECT Dept FROM Dept WHERE College = @College1";
                _command = new SqlCommand(departmentQuery, _connection);
                _command.Parameters.AddWithValue("@College1", row.Cells[1].Text);

                _reader = _command.ExecuteReader();

                Repeater1.DataSource = _reader;
                Repeater1.DataBind();

                _reader.Close();

            }

            Response.Write("Select Grid");

        }
        
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_32\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";
            _connection = new SqlConnection(path);
            _connection.Open();

            string select_q = "select * from Dept;";
            _command = new SqlCommand(select_q, _connection);
            _reader = _command.ExecuteReader();
            
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Repeater repeater = (Repeater)e.Row.FindControl("Repeater1");
                // Bind data to the Repeater
                repeater.DataSource = _reader;
                repeater.DataBind();
            }
            _reader.Close();
        }

    }
}