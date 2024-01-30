using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using BusinessLogic;
using System.Web.Services.Description;


namespace WebApplication1
{
    public partial class reg : System.Web.UI.Page
    {
        userBO bo = new userBO();
        userBL bl = new userBL();
        public int p_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                show_ddl_dept();
                
                ListView1.DataSource = bl.bl_list_show();
                ListView1.DataBind();

                Session["P_id1"] = "";
            }
        }

        protected void show_ddl_dept()
        {
            ddlDept.DataSource = bl.bl_ddl_dept();
            ddlDept.DataTextField = "Dept_name";
            ddlDept.DataBind();
            ddlDept.Items.Insert(0, "Select Degree");

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtemail.Text == "" || txtphone.Text == ""  )
                {
                    throw new Exception("All Field are require");
                }
                else
                {
                    double maxSize = 2 * 1024 * 1024; 

                    if(FileUpload1.PostedFile.ContentLength < maxSize)
                    {
                        if (Session["P_id1"].ToString() == "")
                        {
                            // bo.Id = int.Parse(Session["P_id1"].ToString());
                            bo.Name = txtName.Text;
                            bo.Email = txtemail.Text;
                            bo.Phone = txtphone.Text;
                            bo.pic = FileUpload1.FileName;
                            bo.DOB = txtDOB.Text;
                            bo.Degree = ddlDept.SelectedValue;
                            bo.Gender = radGender.SelectedValue;

                            FileUpload1.SaveAs(Server.MapPath("~") + "//upload//" + FileUpload1.FileName);
                            //Response.Write("<script>alert('Data Insert')</script>");
                            Response.Write(bl.insertdata(bo));
                            //Response.Write("Data Insert");
                        }
                        else
                        {

                            if (txtName.Text == "" || txtemail.Text == "" || txtphone.Text == "" || txtDOB.Text == "" )
                            {
                                throw new Exception("All Field are require in update");
                            }
                            else
                            {
                                bo.Id = int.Parse(Session["P_id1"].ToString());
                                bo.Name = txtName.Text;
                                bo.Email = txtemail.Text;
                                bo.Phone = txtphone.Text;
                                bo.pic = FileUpload1.FileName;
                                bo.DOB = txtDOB.Text;
                                bo.Degree = ddlDept.SelectedValue;
                                bo.Gender = radGender.SelectedValue;

                                FileUpload1.SaveAs(Server.MapPath("~") + "//upload//" + FileUpload1.FileName);
                                Response.Write(bo.Id + "update");
                                Response.Write(bl.insertdata(bo));
                                //Response.Write("<script>alert('Data update')</script>");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Image size must be less than 2 MB");
                    }
                    txtName.Text = "";
                    txtemail.Text = "";
                    txtDOB.Text = "";
                    txtphone.Text = "";
                    ddlDept.ClearSelection();
                    radGender.ClearSelection();
                    btnSubmit.Text = "Submit";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if(e.CommandName == "updatelist")
            {
                Label l_id = (Label)e.Item.FindControl("lblLid");
                bo.Id = int.Parse(l_id.Text);
                Session["P_id1"] = int.Parse(l_id.Text);
                Response.Write(Session["P_id1"].ToString());
                bl.bl_text_fetch(bo);
                txtName.Text = bo.Name;
                txtemail.Text = bo.Email;
                txtphone.Text = bo.Phone;
                txtDOB.Text = bo.DOB;
                ddlDept.ClearSelection();
                ddlDept.Items.Insert(0, bo.Degree);
                radGender.SelectedValue = bo.Gender;
                btnSubmit.Text = "update";
                DBImage1.Visible = true;
                DBImage1.ImageUrl = "/upload/" + bo.pic;

                Response.Write(bo.DOB);
            }
        }
        protected void ddl_list_text()
        {
            ddlDept.DataSource = bl.bl_ddl_dept();
            ddlDept.DataTextField = "Dept_name";
            ddlDept.DataBind();
        }
    }
}