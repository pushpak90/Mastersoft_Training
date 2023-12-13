using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            t_name.Text = (string)Session["name"];
            t_email.Text = (string)Session["email"];
            Button1.Attributes.Add("onclick", "javascript: return choice()");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["col_name"] = txtCollege.Text;
            Session["branch"] = txtBranch.Text;
            Session["sem"] = DropDownList1.SelectedValue;
            Response.Redirect("testscreen.aspx");
        }
    }
}