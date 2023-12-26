using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            deptmaster dm = new deptmaster();
            if(!IsPostBack)
            {
                dm.display((string)Session["d_email"], (string)Session["d_password"]);
                lblName.Text = dm.p_id;
                Session["dd_dept"] = dm.p_dept;
                lblDept.Text = dm.p_dept;
            }
            
        }
    }
}