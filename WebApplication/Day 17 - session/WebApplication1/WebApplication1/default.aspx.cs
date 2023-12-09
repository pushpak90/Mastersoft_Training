using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display drop down data
            //TextBox1.Text = DropDownList1.Text;
            //how to match drop down data
            if(DropDownList1.SelectedIndex == 1)
            {
                TextBox1.Text = "Welcome User";
            }
            else
            {
                TextBox1.Text = "Invalid User";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //insert data element 
            DropDownList1.Items.Add(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //clear drop down data
            DropDownList1.Items.Clear();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Kalmehwar");
            DropDownList1.Items.Add("Bhopal");
            DropDownList1.Items.Add("Fetri");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.Items.Count.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //insert elements 
            DropDownList1.Items.Insert(0, "Select");
        }
    }
}