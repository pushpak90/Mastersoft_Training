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
        string g_name, g_s_name, name, s_name;
        int g_num, num1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Message Button");
            outputscren.InnerHtml = name + "<br>" + s_name + "<br>" + num1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "" || TextBox2.Text == "" || TextBox4.Text == "")
            {
                Response.Write("All input field are require");
            }
            else
            {
                name = TextBox1.Text;
                s_name = TextBox2.Text;
                num1 = int.Parse(TextBox4.Text);
                TextBox3.Text = name+" "+s_name+" "+num1;
                g_name = name;
                g_s_name = s_name;
                g_num = num1;
            }
        }
    }
}