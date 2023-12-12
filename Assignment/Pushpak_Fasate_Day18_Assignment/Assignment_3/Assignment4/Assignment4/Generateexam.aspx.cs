using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class Generateexam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = (string)Session["name"];
            Label2.Text = (string)Session["email"];
            Label3.Text = (string)Session["branch"];
            Label4.Text = (string)Session["sem"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["branch"] = DropDownList1.SelectedValue;
            int sum = 0 ;
            if(RadioButtonList1.SelectedIndex == 1)
            {
                sum++;
            }
            if(RadioButtonList2.SelectedIndex == 0)
            {
                sum++;
            }
            if(RadioButtonList3.SelectedIndex == 0)
            {
                sum++;
            }
            if(RadioButtonList4.SelectedIndex == 1)
            {
                sum++;
            }
            if(RadioButtonList5.SelectedIndex == 0)
            {
                sum++;
            }
            if(RadioButtonList6.SelectedIndex == 2)
            {
                sum++;
            }
            if(RadioButtonList7.SelectedIndex == 2)
            {
                sum++;
            }
            if(RadioButtonList8.SelectedIndex == 1)
            {
                sum++;
            }
            if(RadioButtonList9.SelectedIndex == 3)
            {
                sum++;
            }
            if(RadioButtonList10.SelectedIndex == 0)
            {
                sum++;
            }
            Session["totalmark"] = sum;
            Response.Redirect("Score.aspx");
        }
    }
}