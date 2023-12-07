using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || date.Text == "")
            {
                Response.Write("Enter All Fields");
            }
            else
            {

                string name = username.Text;
                string c_date = date.Text;
                if (c_date == DateTime.Now.ToString("dd/MMM/yyyy"))
                {
                    output1.Text = "Valid User";
                }
                else
                {
                    output1.Text = "Invalid User";
                }
            }
        }
    }
}