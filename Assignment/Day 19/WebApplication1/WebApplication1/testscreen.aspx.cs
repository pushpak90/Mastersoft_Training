using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class testscreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            col_name.Text = (string)Session["col_name"];
            l_name.Text = (string)Session["name"];
            l_email.Text = (string)Session["email"];
            l_sem.Text = (string)Session["sem"];
            Image1.ImageUrl = "~/upload/" + (string)Session["img"];
            Session["mark"] = 0;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;

        }

        protected void que3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;

        }

        protected void que4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
        }

        protected void que5_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 4;
        }

        protected void que6_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 5;
        }

        protected void que7_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 6;
        }

        protected void que8_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 7;

        }

        protected void que9_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 8;
        }

        protected void que10_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 9;
        }

        protected void Score_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (RadioButtonList1.SelectedIndex == 1)
            {
                sum++;
            }
            if (RadioButtonList2.SelectedIndex == 0)
            {
                sum++;
            }
            if (RadioButtonList3.SelectedIndex == 0)
            {
                sum++;
            }
            if (RadioButtonList4.SelectedIndex == 1)
            {
                sum++;
            }
            if (RadioButtonList5.SelectedIndex == 0)
            {
                sum++;
            }
            if (RadioButtonList6.SelectedIndex == 2)
            {
                sum++;
            }
            if (RadioButtonList7.SelectedIndex == 2)
            {
                sum++;
            }
            if (RadioButtonList8.SelectedIndex == 1)
            {
                sum++;
            }
            if (RadioButtonList9.SelectedIndex == 3)
            {
                sum++;
            }
            if (RadioButtonList10.SelectedIndex == 0)
            {
                sum++;
            }
            Session["mark"] = sum;
            Response.Redirect("score.aspx");
        }
    }
}