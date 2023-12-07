using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            v_iv.Text = "Valid User";
            Response.Write("<script>alert('valid User and redirect to the Contact us page')</script>");
        }
    }
}