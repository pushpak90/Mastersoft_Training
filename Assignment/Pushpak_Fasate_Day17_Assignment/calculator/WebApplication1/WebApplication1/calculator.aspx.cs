using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(TextBox1.Text);
            b = int.Parse(TextBox2.Text);
            if(DropDownList1.SelectedIndex == 1)
            {
                c = a + b;
                TextBox3.Text = c.ToString();
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                c = a * b;
                TextBox3.Text = c.ToString();
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                c = a / b;
                TextBox3.Text = c.ToString();
            }
            else if (DropDownList1.SelectedIndex == 4)
            {
                c = a - b;
                TextBox3.Text = c.ToString();
            }
        }
    }
}