using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //Connection 
            string path = ConfigurationManager.AppSettings["oldDB"];
            _connection = new SqlConnection(path);
            _connection.Open();
            //Query
            string select_q = "SELECT * FROM old_student";
            _command = new SqlCommand(select_q, _connection);
            _reader = _command.ExecuteReader();

            ListView1.DataSource = _reader;
            ListView1.DataBind();

            _reader.Close(); 
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Connection 
            string path = ConfigurationManager.AppSettings["oldDB"];
            _connection = new SqlConnection(path);
            _connection.Open();
            //Query
            string insert_q = "INSERT INTO old_student(Id, Name, City) VALUES (@Id1, @Name1, @City1)";
            _command = new SqlCommand(insert_q, _connection);
            _command.Parameters.AddWithValue("Id1", txtRoll.Text);
            _command.Parameters.AddWithValue("Name1", txtName.Text);
            _command.Parameters.AddWithValue("City1", txtCity.Text);

            Response.Write("Data Inserted");

            _command.ExecuteNonQuery();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //Connection 
            string path = ConfigurationManager.AppSettings["oldDB"];
            _connection = new SqlConnection(path);
            _connection.Open();
            //Query
            string find_q = "SELECT * FROM old_student WHERE Id = @Id1";
            _command = new SqlCommand(find_q, _connection);
            _command.Parameters.AddWithValue("Id1",txtRoll.Text);
            _reader = _command.ExecuteReader();

            ListView1.DataSource = _reader;
            ListView1.DataBind();

            _reader.Close();
        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if(e.CommandName == "update")
            {
                //Connection 
                string path = ConfigurationManager.AppSettings["oldDB"];
                _connection = new SqlConnection(path);
                _connection.Open();
                //Find Control
                TextBox txtListId = (TextBox)e.Item.FindControl("txtLid");
                TextBox txtListName = (TextBox)e.Item.FindControl("txtLname");
                TextBox txtListCity = (TextBox)e.Item.FindControl("txtLcity");

                //Query
                string update_q = "UPDATE old_student SET Name = @Name1, City = @City1 WHERE Id = @Id1";
                _command = new SqlCommand(update_q, _connection);
                _command.Parameters.AddWithValue("Id1",txtListId.Text);
                _command.Parameters.AddWithValue("Name1", txtListName.Text);
                _command.Parameters.AddWithValue("City1", txtListCity.Text);

                _command.ExecuteNonQuery();
                Response.Redirect("default.aspx");
            }
            else if(e.CommandName == "delete")
            {
                //Connection 
                string path = ConfigurationManager.AppSettings["oldDB"];
                _connection = new SqlConnection(path);
                _connection.Open();
                //Find Control
                TextBox txtListId = (TextBox)e.Item.FindControl("txtLid");
                //Query
                string update_q = "DELETE FROM old_student WHERE Id = @Id1";
                _command = new SqlCommand(update_q, _connection);
                _command.Parameters.AddWithValue("Id1", txtListId.Text);
                _command.ExecuteNonQuery();
                Response.Redirect("default.aspx");
            }
        }

    }
}