using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Visit next page
            Response.Redirect("about.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Navigation using transfer 
            Server.Transfer("contact.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Display corrent date and time
            Label1.Text = DateTime.Now.ToString();
            //Display only date 
            Label1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //Display only month mm - number, mmm - short(an, feb, dec), mmmm - March
            Label1.Text = DateTime.Now.ToString("MMMM");
            //Display only Year
            Label1.Text = DateTime.Now.ToString("yyyy");
            //how to increase month
            Label1.Text = DateTime.Now.AddMonths(2).ToString("MMMM");
            //increate days
            Label1.Text = DateTime.Now.AddDays(7).ToString("dd/MMM/yyyy");
            // 1 year
            Label1.Text = DateTime.Now.AddYears(1).ToString("dd/MMMM/yyyy");
        }
    }
}