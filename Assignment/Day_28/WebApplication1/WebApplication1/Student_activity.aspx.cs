using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Student_activity : System.Web.UI.Page
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
                string select_q = "Select * from StudentRegDb where Email = @Email1;";
                _command = new SqlCommand(select_q, _connection);
                _command.Parameters.AddWithValue("@Email1", (string)Session["s_email"]);

                _reader = _command.ExecuteReader();

                if(_reader.Read())
                {
                    lblId.Text = _reader["Studentid"].ToString();
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["Mark"];
            _connection = new SqlConnection(path);
            _connection.Open();

            string insert_q = "insert into ActivityDB (ID, Name, Dept, Activity, Org, Dateofactivity, Remark) values (@ID1, @Name1, @Dept1, @Acivity1, @Org1, @Dateofactivity1, @Remark1);";
            _command = new SqlCommand(@insert_q, _connection);
            _command.Parameters.AddWithValue("@ID1 ", (string)Session["g_id"]);
            _command.Parameters.AddWithValue("@Name1 ", lblName.Text);
            _command.Parameters.AddWithValue("@Dept1 ", lblDept.Text);
            _command.Parameters.AddWithValue("@Acivity1", txtAct.Text);
            _command.Parameters.AddWithValue("@Org1", TextBox2.Text);
            _command.Parameters.AddWithValue("@Dateofactivity1 ", txtDate.Text);
            _command.Parameters.AddWithValue("@Remark1 ", TextBox1.Text);



            _command.ExecuteNonQuery();
            Response.Write("Data insert");
        }
    }
}