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
    public partial class Deptmark : System.Web.UI.Page
    {
        SqlConnection _connection;
        SqlCommand _command;
        public SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            deptmark dm = new deptmark();
            dm.show_grid((string)Session["dd_dept"]);
            GridView1.DataSource = dm._reader;
            GridView1.DataBind();
            dm._reader.Close();

           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            string name;
            foreach (GridViewRow r3 in GridView1.Rows)
            {
                if(txtName.Text == r3.Cells[1].Text)
                {
                    name = r3.Cells[1].Text;
                    Response.Write(name.ToString());
                }
                break;
            }
            */
            /*
            deptmark dm = new deptmark();
            dm.find_name();

            GridView1.DataSource = dm._reader;
            GridView1.DataBind();

            dm._reader.Close();
            */
            /*
            string path = ConfigurationManager.AppSettings["Mark"]; 
            _connection = new SqlConnection(path);
            _connection.Open();
            
            string ss_q = "select * From StudentRegDb where Name = @Name1;";

            _command = new SqlCommand(ss_q, _connection);
            _command.Parameters.AddWithValue("@Name1", txtName.Text);
            _reader = _command.ExecuteReader();
            // Connect data control to grid view

            GridView1.DataSource = _reader;
            GridView1.DataBind();

            _reader.Close();
            */
        }

        protected void mark_Click(object sender, EventArgs e)
        {
            
            string path = ConfigurationManager.AppSettings["Mark"];
            _connection = new SqlConnection(path);
            _connection.Open();

            foreach (GridViewRow r1 in GridView1.Rows)
            {
                string ID = r1.Cells[0].Text;
                string Name = r1.Cells[1].Text;
                string Dept = r1.Cells[2].Text;
                string Act = r1.Cells[3].Text;
                string org = r1.Cells[4].Text;

                TextBox txtmark = (TextBox)r1.FindControl("txtmark");

                string k = "insert allotedb (Id, Name, Dept, Activityname, OrgName, Mark) values (@Id1, @Name1, @Dept1, @Activityname1, @OrgName1, @Mark1);";
                _command = new SqlCommand(k, _connection);
                _command.Parameters.AddWithValue("@Id1", ID);
                _command.Parameters.AddWithValue("@Name1", Name);
                _command.Parameters.AddWithValue("@Dept1", Dept);
                _command.Parameters.AddWithValue("@Activityname1", Act);
                _command.Parameters.AddWithValue("@OrgName1", org);
                _command.Parameters.AddWithValue("@Mark1", txtmark.Text);

                _command.ExecuteNonQuery();

                Response.Write("Inserted");
               
            }
             
        }
    }
}