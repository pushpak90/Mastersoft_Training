using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class testscreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            que2.Attributes.Add("onclick", "javascript : return choice()");
            col_name.Text = (string)Session["col_name"];
            l_name.Text = (string)Session["name"];
            l_email.Text = (string)Session["email"];
            l_sem.Text = (string)Session["sem"];
            Image1.ImageUrl = "~/upload/" + (string)Session["img"];
            Session["mark"] = 0;
            
            if(RadioButtonList1.SelectedIndex == -1  ||
                RadioButtonList2.SelectedIndex == -1 ||
                RadioButtonList3.SelectedIndex == -1 ||
                RadioButtonList4.SelectedIndex == -1 ||
                RadioButtonList5.SelectedIndex == -1 ||
                RadioButtonList6.SelectedIndex == -1 ||
                RadioButtonList7.SelectedIndex == -1 ||
                RadioButtonList8.SelectedIndex == -1 ||
                RadioButtonList9.SelectedIndex == -1 ||
                RadioButtonList10.SelectedIndex == -1 
                )
            {
                    this.Score.Visible = false;
            }
            else
            {
                    
                    this.Score.Visible = true;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            que1.BackColor = System.Drawing.Color.Green;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            que2.BackColor = System.Drawing.Color.Green;
        }

        protected void que3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
            que3.BackColor = System.Drawing.Color.Green;
        }

        protected void que4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
            que4.BackColor = System.Drawing.Color.Green;
        }

        protected void que5_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 4;
            que5.BackColor = System.Drawing.Color.Green;
        }

        protected void que6_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 5;
            que6.BackColor = System.Drawing.Color.Green;
        }

        protected void que7_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 6;
            que7.BackColor = System.Drawing.Color.Green;
        }

        protected void que8_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 7;
            que8.BackColor = System.Drawing.Color.Green;
        }

        protected void que9_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 8;
            que9.BackColor = System.Drawing.Color.Green;
        }

        protected void que10_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 9;
            que10.BackColor = System.Drawing.Color.Green;
            
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