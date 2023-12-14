using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create Cookies 
            Response.Cookies["name"].Value = TextBox1.Text;
            //Expire Cookies
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);
            Label1.Text = "Cookies Created";
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //How to retrieve cookies
            if(Request.Cookies["name"] == null)
            {
                TextBox2.Text = "No Cookies Found";
            }
            else
            {
                TextBox2.Text = Request.Cookies["name"].Value;
            }
        }
    }
}