using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            if(DropDownList1.SelectedIndex == 0)
            {
                DropDownList2.Items.Add("MCA");
                DropDownList2.Items.Add("MBA");
                DropDownList2.Items.Add("MTach");
            }
            else
            {
                DropDownList2.Items.Add("CSE");
                DropDownList2.Items.Add("ETC");
                DropDownList2.Items.Add("Mech");
            }
        }
    }
}