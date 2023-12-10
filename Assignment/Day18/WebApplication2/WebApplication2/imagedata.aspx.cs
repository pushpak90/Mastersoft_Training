using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class imagedata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("~") + "//upload//" + FileUpload1.FileName);
            DropDownList1.Items.Add(FileUpload1.FileName);
            //Image1.ImageUrl = "~/upload/" + FileUpload1.FileName;
            //Label2.Text = FileUpload1.FileName;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/upload/" + DropDownList1.SelectedValue;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("preview.aspx?filename=" + DropDownList1.SelectedValue);
        }
    }
}