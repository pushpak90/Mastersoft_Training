using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();

            //query
            
            com = new SqlCommand("curd_op", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", txtRoll.Text);
            com.Parameters.AddWithValue("Name1", txtName.Text);
            com.Parameters.AddWithValue("City1", txtCity.Text);

            com.ExecuteNonQuery();
            Response.Write("Data Insert");
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();

            //query
            com = new SqlCommand("Show_curd1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", txtRoll.Text);
            dr = com.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();

            dr.Close();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();

            //query
            com = new SqlCommand("Find_curd1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", txtRoll.Text);
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                txtRoll.Text = dr["Roll"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtCity.Text = dr["City"].ToString();
            }
            dr.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();
            //query
            com = new SqlCommand("Update_curd1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", txtRoll.Text);
            com.Parameters.AddWithValue("Name1", txtName.Text);
            com.Parameters.AddWithValue("City1", txtCity.Text);

            com.ExecuteNonQuery();
            Response.Write("Data Update");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Connection
            string path = ConfigurationManager.AppSettings["crud"];
            con = new SqlConnection(path);
            con.Open();
            //query
            com = new SqlCommand("Delete_curd1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Roll1", txtRoll.Text);
            com.ExecuteNonQuery();
            Response.Write("Data Delete");
        }
    }
}