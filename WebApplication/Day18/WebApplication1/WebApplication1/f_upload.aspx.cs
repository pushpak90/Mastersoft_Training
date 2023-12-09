using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class f_upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //file uploading
            //FileUpload1.SaveAs(Server.MapPath("~")+"//upload//"+ FileUpload1.FileName);
            //Image1.ImageUrl = "~/upload/"+FileUpload1.FileName;
            i
            Label1.Text = FileUpload1.FileName;
        }
    }
}