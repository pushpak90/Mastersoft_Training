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
    public partial class registration : System.Web.UI.Page
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
            try
            {
                if(string.IsNullOrEmpty(txtId.Text)  && string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtEmail.Text)
                    && string.IsNullOrEmpty(txtMobile.Text) && string.IsNullOrEmpty(ddlCity.SelectedValue) && 
                    string.IsNullOrEmpty(txtAddress.Text) && string.IsNullOrEmpty(txtPin.Text) && 
                    string.IsNullOrEmpty(FileUpload1.FileName))
                {
                    Response.Write("Provide all details");
                }
                else
                {
                    
                    Session["se_id"] = txtId.Text;
                    string path = ConfigurationManager.AppSettings["BioDB"];
                    con = new SqlConnection(path);
                    con.Open();

                    string gen_id = "SELECT Count(Id)+1 FROM BasicInfoDB";
                    com = new SqlCommand(gen_id, con);

                    string auto_id = "BIO-" + DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-00-" + com.ExecuteScalar().ToString();
                    FileUpload1.SaveAs(Server.MapPath("~") + "\\upload\\" + FileUpload1.FileName);
                    string insert_q = "INSERT INTO BasicInfoDB (Id, Name, Email, Mobile, City, Address, Pincode, upload) values (@Id1, @Name1, @Email1, @Mobile1, @City1, @Address1, @Pincode1, @Upload1);";
                    com = new SqlCommand(insert_q, con);
                    com.Parameters.AddWithValue("@Id1", auto_id.ToString());
                    com.Parameters.AddWithValue("@Name1", txtName.Text);
                    com.Parameters.AddWithValue("@Email1", txtEmail.Text);
                    com.Parameters.AddWithValue("@Mobile1", txtMobile.Text);
                    com.Parameters.AddWithValue("@City1", ddlCity.SelectedValue);
                    com.Parameters.AddWithValue("@Address1", txtAddress.Text);
                    com.Parameters.AddWithValue("@Pincode1", txtPin.Text);
                    com.Parameters.AddWithValue("@Upload1", FileUpload1.FileName);

                    com.ExecuteNonQuery();
                    Session["g_id"] = auto_id;
                    Response.Write("<script>alert('Data Inserted')</script>");
                    txtId.Text = auto_id;
                }
            }
            catch(Exception ob)
            {

            }
           
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("Qulification.aspx");   
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BioDB"];
            con = new SqlConnection(path);
            con.Open();

            string update_q = "UPDATE BasicInfoDB set Name = @Name1, Email = @Email1, Mobile = @Mobile1, City = @City1, Address = @Address1, Pincode = @Pincode1, upload = @upload1 WHERE Id = @Id1;";
            com = new SqlCommand(update_q, con);
            com.Parameters.AddWithValue("@id1", (string)Session["g_id"]);
            com.Parameters.AddWithValue("@Name1", txtName.Text);
            com.Parameters.AddWithValue("@Email1", txtEmail.Text);
            com.Parameters.AddWithValue("@Mobile1", txtMobile.Text);
            com.Parameters.AddWithValue("@City1", ddlCity.SelectedValue);
            com.Parameters.AddWithValue("@Address1", txtAddress.Text);
            com.Parameters.AddWithValue("@Pincode1", txtPin.Text);
            com.Parameters.AddWithValue("@Upload1", FileUpload1.FileName);
            com.ExecuteNonQuery();
            Response.Write("Data Updated");
        }
    }
}   