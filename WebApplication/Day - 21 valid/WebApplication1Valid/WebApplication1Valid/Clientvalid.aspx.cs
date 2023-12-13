using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1Valid
{
    public partial class Clientvalid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Access javaScript method 
            btnSubmit.Attributes.Add("onclick", "javascript: return validationCheck()");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("success");
        }
    }
}