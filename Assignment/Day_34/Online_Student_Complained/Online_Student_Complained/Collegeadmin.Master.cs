using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class Collegeadmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCollege.Text = (string)Session["s_col"];
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Collegelogin.aspx");
        }
    }
}