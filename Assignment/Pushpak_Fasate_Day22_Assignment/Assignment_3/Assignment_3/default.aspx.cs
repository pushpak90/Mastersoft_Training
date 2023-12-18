using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            info c1 = new info();
            lblResult.Text = c1.input(txtName.Text, txtCity.Text, txtCollege.Text, txtBranch.Text, 
                int.Parse(txtPer.Text));
            
            lblgrade.Text = c1.grade;

        }
    }
}