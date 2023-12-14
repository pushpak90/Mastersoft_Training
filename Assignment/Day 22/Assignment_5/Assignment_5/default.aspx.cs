using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            marksheet ms = new marksheet();
            lblDsiplay.Text = ms.display(txtName.Text, txtCity.Text, txtCollege.Text);
            int total_mark = ms.total(int.Parse(txtMark1.Text), int.Parse(txtMark2.Text),
                            int.Parse(txtMark3.Text),int.Parse(txtMark4.Text), 
                            int.Parse(txtMark5.Text));
            lblTotal.Text = total_mark.ToString();
            lblGrade.Text = ms.g_grade;
        }
    }
}