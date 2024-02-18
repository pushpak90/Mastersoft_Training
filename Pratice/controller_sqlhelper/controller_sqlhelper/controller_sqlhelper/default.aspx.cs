using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessObject;

namespace controller_sqlhelper
{
    public partial class _default : System.Web.UI.Page
    {
        Common obcom = new Common();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
            obcom.getddldate(ddlBranch, "bind_drop");
        }
    }
}