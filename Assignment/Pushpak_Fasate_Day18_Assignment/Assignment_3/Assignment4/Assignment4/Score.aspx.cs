using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class Score : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label7.Text = (string)Session["name"];
            Label8.Text = (string)Session["email"];
            Label9.Text = (string)Session["branch"];
            Label10.Text = (string)Session["sem"];
            Image1.ImageUrl = "~/upload/" + (string)Session["img"];
           

            int value = (int)Session["totalmark"];
            Label11.Text = value.ToString();
            
            if ((int)Session["totalmark"] > 8)
            {
                Label12.Text = "Grade A";
            }
            else if((int)Session["totalmark"] > 6 && (int)Session["totalmark"] < 8)
            {
                Label12.Text = "Grade A";
            }
            else
            {
                Label12.Text = "Fail";
            }
            
        }
    }
}