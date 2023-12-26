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
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
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
                // All Field Are Required
                if (txtId.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtCollege.Text == "" ||
                    txtMobile.Text == "" || txtBranch.Text == "" || txtTotal.Text == "" || txtPercentage.Text == "")
                {
                    throw new Exception("All Field are Require");
                }
                else
                {
                    //Calculating Grade
                    
                    string grade;
                    if(int.Parse(txtTotal.Text) >= 250)
                    {
                        grade = "Grade A";
                    }
                    else if (int.Parse(txtTotal.Text) >= 150 && int.Parse(txtTotal.Text) <= 250)
                    {
                        grade = "Grade B";
                    }
                    else if (int.Parse(txtTotal.Text) >= 100 && int.Parse(txtTotal.Text) <= 150)
                    {
                        grade = "Grade C";
                    }
                    else
                    {
                        grade = "Fail";
                    }
                    txtGrade.Text = grade;

                    //Connecting database
                    string path = ConfigurationManager.AppSettings["stuDB"];
                    conn = new SqlConnection(path);
                    conn.Open();

                    //insert query
                    string insert_q = "INSERT INTO student (Id, Name, Email, Mobile, College, Branch, Status, Total, percentage, Grade) VALUES (@Id1, @Name1, @Email1, @Mobile1, @College1, @Branch1, @Status1, @Total1, @percentage1, @Grade1)";
                    cmd = new SqlCommand(insert_q, conn);
                    cmd.Parameters.AddWithValue("@Id1", txtId.Text);
                    cmd.Parameters.AddWithValue("@Name1", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email1", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Mobile1", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@College1", txtCollege.Text);
                    cmd.Parameters.AddWithValue("@Branch1", txtBranch.Text);
                    cmd.Parameters.AddWithValue("@Status1","");
                    cmd.Parameters.AddWithValue("@Total1", txtTotal.Text);
                    cmd.Parameters.AddWithValue("@percentage1", txtPercentage.Text);
                    cmd.Parameters.AddWithValue("@Grade1", grade.ToString());

                    //Execute Query
                    cmd.ExecuteNonQuery();
                    
                    Response.Write("<Script>alert('Data Inserted')</Script>");
                }
            }
            catch (Exception ex)
            {
                //Response.Write(ex);
                Response.Write("All Field are Require");  
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //Connecting database
            string path = ConfigurationManager.AppSettings["stuDB"];
            conn = new SqlConnection(path);
            conn.Open();

            //How data in grid
            string select_q = "SELECT * FROM student;";
            cmd = new SqlCommand(select_q, conn);
            reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                GridViewRow rd = ((GridViewRow)sender).NamingContainer as GridViewRow;
                DropDownList sel = (DropDownList)rd.FindControl("DropDownList1");
                sel.SelectedValue = reader["Status"].ToString();
            }

            GridView1.DataSource = reader;
            GridView1.DataBind();


            reader.Close();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            
            GridViewRow rd = ((Button)sender).NamingContainer as GridViewRow;
            string g_id = rd.Cells[1].Text;
            
            DropDownList sel = (DropDownList)rd.FindControl("DropDownList1");
            string sele = sel.Text;

            string path = ConfigurationManager.AppSettings["stuDB"];
            conn = new SqlConnection(path);
            conn.Open();


            //insert query
            string update_q = "UPDATE student SET Status = @Status1 WHERE Id = @Id1";
            cmd = new SqlCommand(update_q, conn);
            
            cmd.Parameters.AddWithValue("@Id1", g_id.ToString());
            cmd.Parameters.AddWithValue("@Status1", sele.ToString());

            cmd.ExecuteNonQuery();

            Response.Write("Updated");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            string path = ConfigurationManager.AppSettings["stuDB"];
            conn = new SqlConnection(path);
            conn.Open();

            //How data in grid
            string select_q = "SELECT * FROM student;";
            cmd = new SqlCommand(select_q, conn);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                GridViewRow rd = ((Button)sender).NamingContainer as GridViewRow;
                DropDownList sel = (DropDownList)rd.FindControl("DropDownList1");
                sel.SelectedValue = reader["Status"].ToString();
            }

            GridView1.DataSource = reader;
            GridView1.DataBind();


            reader.Close();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableCell cell = e.Row.Cells[7];
                
                string garde = cell.Text;
                if (garde == "Grade B")
                {
                    cell.BackColor = Color.Yellow;
                }
            }

                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    // Assuming the grade is in the third cell of each row (index 2)
                    string grade = e.Row.Cells[7].Text;

                    // Assuming the View button is in the last cell of each row
                    Button btnView = (Button)e.Row.Cells[e.Row.Cells.Count - 1].FindControl("btnView");

                    // Check if the grade is 'A'
                    if (grade.Equals("Grade A", StringComparison.OrdinalIgnoreCase))
                    {
                        // Enable the View button
                        btnView.Enabled = true;
                    }
                    else
                    {
                        // Disable the View button for grades other than 'A'
                        btnView.Enabled = false;
                    }
                }
            

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow rd = ((Button)sender).NamingContainer as GridViewRow;
            string g_id = rd.Cells[1].Text;


            string path = ConfigurationManager.AppSettings["stuDB"];
            conn = new SqlConnection(path);
            conn.Open();


            //insert query
            string delete_q = "DELETE FROM student where Id = @Id1";
            cmd = new SqlCommand(delete_q, conn);

            cmd.Parameters.AddWithValue("@Id1", g_id.ToString());

            cmd.ExecuteNonQuery();
            Response.Redirect("default.aspx");
            Response.Write("Delete");
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
           
            GridViewRow rd = ((Button)sender).NamingContainer as GridViewRow;
            Session["s_id"] = rd.Cells[1].Text;
            Response.Redirect("report.aspx");
        }
    }
}