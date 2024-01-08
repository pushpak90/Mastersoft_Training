using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessObject;

namespace WebApplication1
{
    public partial class StudentReg : System.Web.UI.Page
    {
        UserBL bl = new UserBL();
        UserBO bo = new UserBO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddld_show();
                GridView1.DataSource = bl.grid_da();
                GridView1.DataBind();
            }
        }

        protected void ddld_show()
        {
            ddlDegree.DataSource = bl.ddldeg_da();
            ddlDegree.DataTextField = "DegreeName";
            ddlDegree.DataBind();
            ddlDegree.Items.Insert(0, "Select Degree");

        }

        protected void ddlDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            bo.Sel_deg = ddlDegree.SelectedValue;
            ddlBranch.DataSource = bl.ddlbranch_da(bo);
            ddlBranch.DataTextField = "BranchName";
            ddlBranch.DataBind();
            ddlBranch.Items.Insert(0, "Select Branch");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtName.Text == "" || ddlDegree.SelectedIndex == 0 || ddlBranch.SelectedIndex == 0 || txtEmail.Text == "" || 
                    txtMobile.Text == "")
                {
                    throw new Exception("All Field are require");
                }
                else
                {
                    double file_s = FileUpload1.PostedFile.ContentLength;
                    int max_s = 200 * 1024;
                    if(file_s < max_s)
                    {
                        if (CheckBox1.Checked)
                        {
                            bo.sName = txtName.Text;
                            bo.DOB = txtdate.Text;
                            bo.Gender = RadioButtonList1.SelectedValue;
                            bo.Degree = ddlDegree.SelectedValue;
                            bo.Branch = ddlBranch.SelectedValue;
                            bo.Email = txtEmail.Text;
                            bo.Mobile = txtMobile.Text;
                            bo.Upload = FileUpload1.FileName;
                            bo.Check = "Active";
                            FileUpload1.SaveAs(Server.MapPath("~") + "//upload//" + FileUpload1.FileName);
                            bl.insert_stu(bo);
                            GridView1.DataSource = bl.grid_da();
                            GridView1.DataBind();
                        }
                        else
                        {
                            Response.Write("<Script>alert('Selete Status')</Script>");
                        }
                    }
                    else
                    {
                        Response.Write("<Script>alert('Image size must be less than 200kb')</Script>");
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            Calendar1.SelectedDates.Clear();
            RadioButtonList1.ClearSelection();
            ddlBranch.Items.Clear();
            ddlDegree.Items.Clear();
            txtEmail.Text = "";
            txtMobile.Text = "";
            CheckBox1.Checked = false;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow g1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtname1 = (TextBox)g1.FindControl("txtGName");
            TextBox txtGgender1 = (TextBox)g1.FindControl("txtGgender");

            bo.sName = txtname1.Text;
            bo.Gender = txtGgender1.Text;

            bl.delete_rec(bo);
            GridView1.DataSource = bl.grid_da();
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtname1 = (TextBox)r1.FindControl("txtGName");
            TextBox txtGgender1 = (TextBox)r1.FindControl("txtGgender");
            TextBox txtGDegree1 = (TextBox)r1.FindControl("txtGDegree");
            TextBox txtGBranch1 = (TextBox)r1.FindControl("txtGBranch");
            TextBox txtDOB1 = (TextBox)r1.FindControl("txtGdob");
            FileUpload File = (FileUpload)r1.FindControl("FileUpload2");

            bo.sName = txtname1.Text;
            bo.Gender = txtGgender1.Text;
            bo.Degree = txtGDegree1.Text;
            bo.Branch = txtGBranch1.Text;
            bo.DOB = txtDOB1.Text;
            bo.Upload = File.FileName;
            File.SaveAs(Server.MapPath("~")+"//upload//"+File.FileName);
            Response.Write(bl.update_rec_da(bo));

            GridView1.DataSource = bl.grid_da();
            GridView1.DataBind();
        }
    }
}