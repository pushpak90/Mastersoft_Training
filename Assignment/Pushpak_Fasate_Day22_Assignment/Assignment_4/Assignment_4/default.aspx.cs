using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            lblResult.Text = s1.display(txtName.Text, txtCollege.Text, txtSubject.Text, txtBranch.Text);
            lblPer.Text = s1.cal_grade(int.Parse(txtPer.Text));
            lblGarde.Text = s1.grade;
        }
    }
}