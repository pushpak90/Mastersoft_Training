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
    public partial class classobj : System.Web.UI.Page
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
            operation_curd o1 = new operation_curd();
            o1.insert_q(int.Parse(txtRoll.Text), txtName.Text, txtCity.Text);
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            operation_curd f1 = new operation_curd();
            f1.find_q(int.Parse(txtRoll.Text), txtName.Text, txtCity.Text);
            if(f1.dr.Read())
            {
                txtRoll.Text = f1.dr["Roll"].ToString();
                txtName.Text = f1.dr["Name"].ToString();
                txtCity.Text = f1.dr["City"].ToString();
            }
            f1.dr.Close();
            Response.Write("Done");
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            operation_curd s1 = new operation_curd();
            s1.show_q();
            GridView1.DataSource = s1.dr;
            GridView1.DataBind();
            s1.dr.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            operation_curd u1 = new operation_curd();
            u1.update_q(int.Parse(txtRoll.Text), txtName.Text, txtCity.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            operation_curd d1 = new operation_curd();
            d1.delete_q(int.Parse(txtRoll.Text));
        }
    }
}