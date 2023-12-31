using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class stulogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            logstu lo = new logstu();
            lo.passemail(txtEmail.Text, txtPasswrod.Text);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("stureg.aspx");
        }
    }
}