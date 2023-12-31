using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class studentcomplaint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCollegeName.Text = (string)Session["s_college"];
            txtStudentName.Text = (string)Session["s_name"];
            txtEmail.Text = (string)Session["s_Email"];
            txtbranch.Text = (string)Session["s_branch"];
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            stucomp stu1 = new stucomp();
            stu1.f_insert(txtCollegeName.Text, txtStudentName.Text, txtEmail.Text, txtbranch.Text, 
                ddlcomp.SelectedValue, txtMessage.Text, txtDate.Text);
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            stucomp stu2 = new stucomp();
            stu2.show_grid();
            GridView1.DataSource = stu2._reader;
            GridView1.DataBind();
            stu2._reader.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow g1 = ((Button)sender).NamingContainer as GridViewRow;

            Label lblcol = (Label)g1.FindControl("lblcolname");
            Label lblname = (Label)g1.FindControl("lblSname");
            Label lblb = (Label)g1.FindControl("lblBranch");
            Label lblcom = (Label)g1.FindControl("txtComplaint");
            Label lblmess = (Label)g1.FindControl("lblmsg");


            stucomp stu3 = new stucomp();
            stu3.del_rec(lblcol.Text, lblname.Text, lblb.Text, lblcom.Text, lblmess.Text);
        }
    }
}