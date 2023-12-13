using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = (string)Session["name"];
            lblEmail.Text = (string)Session["email"];
            lblPin.Text = (string)Session["pincode"];
            lblCemail.Text = (string)Session["c_email"];
            lblMobile.Text = (string)Session["mobile"];
            lblPassword.Text = (string)Session["password"];
        }
    }
}