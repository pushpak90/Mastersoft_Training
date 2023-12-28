using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
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

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Connection 
            string path = ConfigurationManager.AppSettings["mydb"];
            con = new SqlConnection(path);
            con.Open();

            FileUpload1.SaveAs(Server.MapPath("~" + "//upload//") + FileUpload1.FileName);

            //Query
            string select_q = "Insert into product (Id, Prodname, Cost, Photo, Sellcost) values (@Id1, @Prodname1, @Cost1, @Photo1, @Sellcost1);";
            com = new SqlCommand(select_q, con);
            com.Parameters.AddWithValue("@Id1", txtId.Text);
            com.Parameters.AddWithValue("@Prodname1", txtName.Text);
            com.Parameters.AddWithValue("@Cost1", txtCost.Text);
            com.Parameters.AddWithValue("@Photo1", FileUpload1.FileName);
            com.Parameters.AddWithValue("@Sellcost1", txtSellcost.Text);

            com.ExecuteNonQuery();

            Response.Write("Data Insert");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Connection 
            string path = ConfigurationManager.AppSettings["mydb"];
            con = new SqlConnection(path);
            con.Open();
            //Query
            string select_q = "SELECT * FROM product";
            com = new SqlCommand(select_q, con);

            dr = com.ExecuteReader();

            DataList1.DataSource = dr;
            DataList1.DataBind();

            dr.Close();

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //Connection 
            string path = ConfigurationManager.AppSettings["mydb"];
            con = new SqlConnection(path);
            con.Open();
            if (e.CommandName == "buy")
            {
                TextBox txtob = (TextBox)e.Item.FindControl("TextBox1");
                Label lblob1 = (Label)e.Item.FindControl("lblName");
                //Query
                string q = "Select * From product where Prodname = @Prodname1";
                com = new SqlCommand(q, con);
                com.Parameters.AddWithValue("@Prodname1", lblob1.Text);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (int.Parse(txtob.Text) > int.Parse(dr["Cost"].ToString()) && int.Parse(txtob.Text) < int.Parse(dr["Sellcost"].ToString()))
                    {
                        Session["name"] = dr["Prodname"].ToString();
                        Session["userprice"] = txtob.Text;
                        Response.Redirect("product_view.aspx");
                    }
                    else
                    {
                        Response.Write("Can not Buy");
                    }
                }
                dr.Close();
            }

        }
    }
}