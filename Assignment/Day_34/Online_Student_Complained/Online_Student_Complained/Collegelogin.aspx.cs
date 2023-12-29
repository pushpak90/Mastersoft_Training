using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class Collegelogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("Collegereg.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            login_de l1 = new login_de();
            l1.passemail(txtEmail.Text, txtPasswrod.Text);

        }
    }
}