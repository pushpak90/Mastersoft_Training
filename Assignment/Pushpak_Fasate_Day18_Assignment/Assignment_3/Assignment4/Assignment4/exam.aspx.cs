using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            l_name1.Text = (string)Session["name"];
            l_email1.Text = (string)Session["email"];
            l_mobile1.Text = (string)Session["mobile"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["branch"] = DropDownList1.SelectedValue;
            Session["sem"] = DropDownList2.SelectedValue;
            Session["shift"] = DropDownList3.SelectedValue;
            //Session["name"] = name.Text;
            Response.Redirect("Generateexam.aspx");
        }
    }
}