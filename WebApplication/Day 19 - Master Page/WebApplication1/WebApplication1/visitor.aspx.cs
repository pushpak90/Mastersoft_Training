using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class visitor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Comment display number of visitor
            int count = 0;
            if(Application["visit"] != null)
            {
                count = int.Parse(Application["visit"].ToString());
            }
            //increment count 
            count = count + 1;
            Application["visit"] = count;
            Label1.Text = "Number of visitor is " + count.ToString();
        }
    }
}