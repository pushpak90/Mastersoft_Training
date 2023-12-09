using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int m1, m2, total;
            if(RadioButtonList1.SelectedIndex == 2)
            {
                TextBox1.Text = "1";
            }
            else
            {
                TextBox1.Text = "0";
            }
            if(RadioButtonList2.SelectedIndex == 1)
            {
                TextBox2.Text = "1";
            }
            else
            {
                TextBox2.Text = "0";
            }
            m1 = int.Parse(TextBox1.Text);
            m2 = int.Parse(TextBox2.Text);
            total = m1 + m2;
            Label1.Text = total.ToString();
        }
    }
}