using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                data();
            }
        }

        protected void data()
        {
            string path = ConfigurationManager.AppSettings["data"];
            con = new SqlConnection(path);
            con.Open();

            string show = "select * from grid_view";
            com = new SqlCommand(show, con);

            dr = com.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["data"];
            con = new SqlConnection(path);
            con.Open();

            string i = "update grid_view set Name=@Name1 , City=@City1 where Roll= @Roll1";
            com = new SqlCommand(i, con);

            com.Parameters.AddWithValue("Roll1", txtRoll.Text);
            com.Parameters.AddWithValue("Name1", txtName.Text);
            com.Parameters.AddWithValue("City1", ddlCity.SelectedValue);

            com.ExecuteNonQuery();
            Response.Redirect("Default.aspx");
            Response.Write("data updated");
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["data"];
            con = new SqlConnection(path);
            con.Open();

            string i = "insert into grid_view (Roll ,Name,City) values (@Roll1,@Name1,@City1)";
            com = new SqlCommand(i, con);

            com.Parameters.AddWithValue("Roll1", txtRoll.Text);
            com.Parameters.AddWithValue("Name1", txtName.Text);
            com.Parameters.AddWithValue("City1", ddlCity.SelectedValue);

            com.ExecuteNonQuery();
            Response.Redirect("Default.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["data"];
            con = new SqlConnection(path);
            con.Open();

            string i = "Delete from grid_view where Roll= @Roll1";
            com = new SqlCommand(i, con);

            com.Parameters.AddWithValue("Roll1", txtRoll.Text);

            com.ExecuteNonQuery();
            Response.Redirect("Default.aspx");
            Response.Write("data deleted");
        }
    }
}