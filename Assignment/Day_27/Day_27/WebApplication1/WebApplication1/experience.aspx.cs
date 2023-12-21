using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace WebApplication1
{
    public partial class experience : System.Web.UI.Page
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtId.Text = (string)Session["g_id"];
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BioDB"];
            _connection = new SqlConnection(path);
            _connection.Open();
            string selectedDateString = Calendar1.SelectedDate.ToString("yyyy/MM/dd");

            string insert_q = "INSERT INTO Exp (Id, YOE, Namecomp, Dateofj, Otherexp) VALUES (@id1, @YOE1, @Namecomp1, @Dateofj1, @Otherexp1);";
            _command = new SqlCommand(insert_q, _connection);
            _command.Parameters.AddWithValue("@id1", (string)Session["g_id"]);
            _command.Parameters.AddWithValue("@YOE1", ddlExp.SelectedValue);
            _command.Parameters.AddWithValue("@NameComp1", txtComp.Text);
            _command.Parameters.AddWithValue("@Dateofj1", selectedDateString);
            _command.Parameters.AddWithValue("@Otherexp1",txtOther.Text);

            _command.ExecuteNonQuery();

            Response.Write("Data Inserted");
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("objective.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BioDB"];
            _connection = new SqlConnection(path);
            _connection.Open();
            string selectedDateString = Calendar1.SelectedDate.ToString("yyyy/MM/dd");

            string update_q = "UPDATE Exp SET YOE = @YOE1, Namecomp = @Namecomp1, Dateofj = @Dateofj1, Otherexp = @Otherexp1 WHERE Id = @Id1";
            _command = new SqlCommand(update_q, _connection);
            _command.Parameters.AddWithValue("@Id1", (string)Session["g_id"]);
            _command.Parameters.AddWithValue("@YOE1", ddlExp.SelectedValue);
            _command.Parameters.AddWithValue("@Namecomp1", txtComp.Text);
            _command.Parameters.AddWithValue("@Dateofj1", selectedDateString);
            _command.Parameters.AddWithValue("@Otherexp1", txtOther.Text);

            _command.ExecuteNonQuery();

            Response.Write(" Data Update");
        }
    }
}