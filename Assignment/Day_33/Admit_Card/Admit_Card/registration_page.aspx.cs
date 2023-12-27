using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admit_Card
{
    public partial class registration_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            reg r1 = new reg();
            r1.data_input(
                txtApplication.Text,
                txtEnrollment.Text,
                txtName.Text,
                txtDob.Text,
                txtCast.Text,
                txtGender.Text,
                txtDateofexam.Text,
                txtTime.Text,
                txtExamCenter.Text,
                FileUpload1.FileName,
                FileUpload2.FileName
                );
            FileUpload1.SaveAs(Server.MapPath("~" + "//img//") + FileUpload1.FileName);
            FileUpload2.SaveAs(Server.MapPath("~" + "//sig//") + FileUpload2.FileName);
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            reg r2 = new reg();
            r2.show_data();
            GridView1.DataSource = r2.dr;
            GridView1.DataBind();
            r2.dr.Close();
        }

        protected void brnAdmit_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            Session["s_enroll"] = r1.Cells[2].Text;
            Response.Redirect("admit.aspx");
        }
    }
}