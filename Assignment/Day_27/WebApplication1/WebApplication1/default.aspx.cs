using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader rd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string grade;
            //Storing roll no in session for display in next page
            con = new SqlConnection();
            Session["name"] = txtName.Text;
            Session["roll"] = txtRoll.Text;

            if(int.Parse(txtMark1.Text) > 40 && 
                int.Parse(txtMark2.Text) > 40 && 
                int.Parse(txtMark3.Text) > 40 &&
                int.Parse(txtMark1.Text) > 40 &&
                int.Parse(txtMark1.Text) > 40
                )
            {

                

                //calculate Sum
                int total = int.Parse(txtMark1.Text) + int.Parse(txtMark2.Text) + int.Parse(txtMark3.Text) + int.Parse(txtMark4.Text) + int.Parse(txtMark5.Text);
                if (total > 250)
                {
                    grade = "Grade A";
                }
                else if (total > 150 && total < 250)
                {
                    grade = "Grade B";
                }
                else
                {
                    grade = "Fail";
                }

                string city = ddlCity.SelectedValue;
                string subject = ddlSubject.SelectedValue;

                txtTotal.Text = total.ToString();
                txtGrade.Text = grade;

                //Adding connection path
                string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_26\WebApplication1\WebApplication1\App_Data\College.mdf;Integrated Security=True";
                con = new SqlConnection(path);
                con.Open();
                

                //checking roll number 
                string check_roll = "SELECT * FROM Student WHERE Roll = @Roll1";
                com = new SqlCommand(check_roll, con);
                com.Parameters.AddWithValue("@Roll1", txtRoll.Text);

                rd = com.ExecuteReader();

                if(rd.Read())
                {
                    Response.Write("Data is already avalable");
                }
                else
                {
                    //Apply query to insert data
                    string insert_q = "INSERT INTO Student (Roll, Name, Email, Mobile, City, Subject, Mark1, Mark2, Mark3, Mark4, Mark5, Total, Grade) VALUES (@Roll1, @Name1, @Email1, @Mobile1, @City1, @Subject1, @Mark01, @Mark02, @Mark03, @Mark04, @Mark05, @Total1, @Grade1)";
                    com = new SqlCommand(insert_q, con);

                    //pass control through query
                    com.Parameters.AddWithValue("Roll1", txtRoll.Text);
                    com.Parameters.AddWithValue("Name1", txtName.Text);
                    com.Parameters.AddWithValue("Email1", txtEmail.Text);
                    com.Parameters.AddWithValue("Mobile1", txtMobile.Text);
                    com.Parameters.AddWithValue("City1", city);
                    com.Parameters.AddWithValue("Subject1", subject);
                    com.Parameters.AddWithValue("Mark01", txtMark1.Text);
                    com.Parameters.AddWithValue("Mark02", txtMark2.Text);
                    com.Parameters.AddWithValue("Mark03", txtMark3.Text);
                    com.Parameters.AddWithValue("Mark04", txtMark4.Text);
                    com.Parameters.AddWithValue("Mark05", txtMark5.Text);
                    com.Parameters.AddWithValue("Total1", total);
                    com.Parameters.AddWithValue("Grade1", grade);
                    //Sucessfully data inseted message
                    Response.Write("Data Inserted");
                    
                }
                
                rd.Close();
                //Execute Query
                com.ExecuteNonQuery();
                Response.Redirect("Message.aspx?roll_i=" + txtRoll.Text);
            }
            else
            {
                Response.Write("Marks must be greater than 40");
            }
           
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_26\WebApplication1\WebApplication1\App_Data\College.mdf;Integrated Security=True";
            con = new SqlConnection(path);
            con.Open();
            //For updateing data
            string update_q = "UPDATE Student SET Name = @Name1, Email = @Email1, Mobile = @Mobile1, City = @City1 WHERE Roll = @Roll1";
            com = new SqlCommand(update_q, con);
            com.Parameters.AddWithValue("@Roll1", txtRoll.Text);
            com.Parameters.AddWithValue("@Name1", txtName.Text);
            com.Parameters.AddWithValue("@Email1", txtEmail.Text);
            com.Parameters.AddWithValue("@Mobile1", txtMobile.Text);
            com.Parameters.AddWithValue("@City1", ddlCity.SelectedValue);

            com.ExecuteNonQuery();
            Response.Write("Data updat");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_26\WebApplication1\WebApplication1\App_Data\College.mdf;Integrated Security=True";
            con = new SqlConnection(path);
            con.Open();
            //For updateing data
            string update_q = "DELETE FROM Student WHERE Roll = @Roll1";
            com = new SqlCommand(update_q, con);
            com.Parameters.AddWithValue("@Roll1", txtRoll.Text);
            
            com.ExecuteNonQuery();
            Response.Write("Data Deleted");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pushpak\Desktop\MasterSoft\Assignment\Day_26\WebApplication1\WebApplication1\App_Data\College.mdf;Integrated Security=True";
            con = new SqlConnection(path);
            con.Open();
            //For DELETE record
            string find_q = "select * From Student WHERE Roll = @Roll1";
            com = new SqlCommand(find_q, con);
            com.Parameters.AddWithValue("@Roll1", txtRoll.Text);

            rd = com.ExecuteReader();

            if(rd.Read())
            {
                txtName.Text = rd["Name"].ToString();
                txtEmail.Text = rd["Email"].ToString();
                txtMobile.Text = rd["Mobile"].ToString();
                ddlCity.SelectedValue = rd["City"].ToString();
                ddlSubject.SelectedValue = rd["Subject"].ToString();
                txtMark1.Text = rd["Mark1"].ToString();
                txtMark2.Text = rd["Mark2"].ToString();
                txtMark3.Text = rd["Mark3"].ToString();
                txtMark4.Text = rd["Mark4"].ToString();
                txtMark5.Text = rd["Mark5"].ToString();
                txtTotal.Text = rd["Total"].ToString();
                txtGrade.Text = rd["Grade"].ToString();
            }
            else
            {
                Response.Write("Record not avaiable");
            }
            rd.Close();
        }
    }
}