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
            if(!IsPostBack)
            {
                
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtId.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" )
                {
                    Response.Write("Provide all Field");
                }
                else
                {
                    string path = ConfigurationManager.AppSettings["Mark"];
                    _connection = new SqlConnection(path);
                    _connection.Open();

                    string auto_create = "select count(Studentid)+1 from StudentRegDb";
                    _command = new SqlCommand(auto_create, _connection);

                    Session["g_id"] = "STU-" + DateTime.Now.ToString("yyyy") + ("-") + ddlBranch.SelectedValue + "-00-" + _command.ExecuteScalar().ToString();
                    txtId.Text = (string)Session["g_id"];
                    string date_c = DateTime.Now.ToString("dd/MM/yyyy");
                    // add query
                    string c_command = "insert into StudentRegDb (Studentid , Name, Email,Dept,Password,Date) values (@Studentid1 , @Name1, @Email1,@Dept1,@Password1,@Date1) ";
                    _command = new SqlCommand(c_command, _connection);

                    //parameter
                    _command.Parameters.AddWithValue("@Studentid1 ", txtId.Text);
                    _command.Parameters.AddWithValue("@Name1 ", txtName.Text);
                    _command.Parameters.AddWithValue("@Email1 ", txtEmail.Text);
                    _command.Parameters.AddWithValue("@Dept1 ", ddlBranch.SelectedValue);
                    _command.Parameters.AddWithValue("@Password1 ", txtPassword.Text);
                    _command.Parameters.AddWithValue("@Date1 ", date_c.ToString());



                    _command.ExecuteNonQuery();
                    Response.Write("Data Inserted");
                }
            }
            catch 
            {
                
            }
        }
    }
}