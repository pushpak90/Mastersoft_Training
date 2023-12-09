using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            if(DropDownList1.SelectedIndex == 1)
            {
                DropDownList2.Items.Add("MH");
                DropDownList2.Items.Add("MP");
                DropDownList2.Items.Add("UP");
                DropDownList2.Items.Add("Bihar");
            }
            else
            {
                Response.Write("Invalid Username");
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            if(DropDownList2.SelectedIndex == 0)
            {
                DropDownList3.Items.Add("Mumbai");
                DropDownList3.Items.Add("Pune");
                DropDownList3.Items.Add("Nagpur");
            }
            else if(DropDownList2.SelectedIndex == 1)
            {
                DropDownList3.Items.Add("Sausar");
                DropDownList3.Items.Add("Chinwada");
                DropDownList3.Items.Add("Pandhurna");
            }
            else if(DropDownList2.SelectedIndex == 2)
            {
                DropDownList3.Items.Add("Andhra Pradesh");
                DropDownList3.Items.Add("Himachal Pradesh");
                DropDownList3.Items.Add("Uttarakhand");
            }
            else if(DropDownList2.SelectedIndex == 3)
            {
                DropDownList3.Items.Add("Araria");
                DropDownList3.Items.Add("Begusarai");
                DropDownList3.Items.Add("Patna");
            }
            else
            {
                Response.Write("Invalid Server");
            }
        }
    }
}