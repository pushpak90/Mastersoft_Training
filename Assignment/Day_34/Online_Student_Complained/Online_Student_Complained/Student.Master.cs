using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class Student : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblemail.Text = (string)Session["s_Email"];
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("stulogin.aspx");
        }
    }
}