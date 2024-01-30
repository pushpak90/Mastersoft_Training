using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "C://Users//Pushpak//Desktop//upload//";
            DirectoryInfo dir = new DirectoryInfo(path);

            if (dir.Exists)
            {
                if(File.Exists("dir"))
                {
                    string filename = DateTime.Now.ToString("dd/MMM/yyyy") + FileUpload1.FileName;
                    FileUpload1.SaveAs(dir + filename);
                    Response.Write(" ex Uploaded");
                }
                else
                {
                    FileUpload1.SaveAs(dir + FileUpload1.FileName);
                    Response.Write("Uploaded");

                }
            }
            else
            {
                string path1 = "C://Users//Pusnohpak//Desktop//upload//upload//";
                DirectoryInfo dir1 = new DirectoryInfo(path1);
                dir1.Create();
                FileUpload1.SaveAs(dir1 + FileUpload1.FileName);
                Response.Write("some think went worng");
            }
        }
    }
}