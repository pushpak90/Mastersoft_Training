using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int total;
            College c1 = new College();
            total = c1.marktotal(int.Parse(TextBox5.Text), 
                int.Parse(TextBox6.Text),
                int.Parse(TextBox7.Text),
                int.Parse(TextBox8.Text),
                int.Parse(TextBox9.Text));
            TextBox10.Text = total.ToString();
            TextBox11.Text = c1.g_grade;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //Display selected date 
            TextBox12.Text = Calendar1.SelectedDate.ToString("dd/MM/yy");
        }
    }
}