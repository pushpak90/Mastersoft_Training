using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class score : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            name.Text = (string)Session["name"];
            email.Text = (string)Session["email"];
            branch.Text = (string)Session["branch"];
            sem.Text = (string)Session["sem"];
            //mark.Text = (string)Session["mark"];
            
            int mark_q = (int)Session["mark"];
            mark.Text = mark_q.ToString();
            Image1.ImageUrl = "~/upload/" + (string)Session["img"];

            if(8 < mark_q)
            {
                grade.Text = "Grade A";
            }
            else if(mark_q > 6 && mark_q < 8)
            {
                grade.Text = "Grade B";
            }
            else
            {
                grade.Text = "Fail";
            }
            
        }
    }
}