using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2
{
    public partial class DOB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int select_date = int.Parse(Calendar1.SelectedDate.ToString("yyyy"));
            int current_date = int.Parse(DateTime.Now.ToString("yyyy"));

            int cal_age = current_date - select_date;

            txtAge.Text = cal_age.ToString();
        }
    }
}