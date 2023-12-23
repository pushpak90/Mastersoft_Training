using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Message : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader rd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string name_i = ;
                string name = (string)Session["name"];
                string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_26\WebApplication1\WebApplication1\App_Data\College.mdf;Integrated Security=True";
                con = new SqlConnection(path);
                con.Open();
                //For DELETE record
                string find_q = "select * From Student WHERE Roll = @Roll1";
                com = new SqlCommand(find_q, con);
                com.Parameters.AddWithValue("@Roll1", (string)Session["roll"]);

                rd = com.ExecuteReader();

                if (rd.Read())
                {
                    lblName.Text = rd["Name"].ToString();
                    lblRoll.Text = rd["Roll"].ToString();
                    lblEmail.Text = rd["Email"].ToString();
                    lblMobile.Text = rd["Mobile"].ToString();
                    lblCity.Text = rd["City"].ToString();
                    lblSubject.Text = rd["Subject"].ToString();
                    lblTotal.Text = rd["Total"].ToString();
                    lblGrade.Text = rd["Grade"].ToString();
                }
                else
                {
                    Response.Write("Record not avaiable");
                }
                rd.Close();
            }
        }
    }
}