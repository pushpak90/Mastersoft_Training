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
                Class1 c1 = new Class1();
                
                c1.display((string)Session["s_email"], (string)Session["s_password"]);
                lblId.Text = c1.p_id;
                lblName.Text = c1.p_name;
                lblDept.Text = c1.p_dept;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Class1 c2 = new Class1();
            c2.act(lblId.Text, lblName.Text, lblDept.Text, txtAct.Text, txtDate.Text, TextBox2.Text, TextBox1.Text);
        }
    }
}