using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Studentmaster : System.Web.UI.MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            s_master sm = new s_master();
            if (!IsPostBack)
            {
                sm.display((string)Session["s_email"]);
                lblName.Text = sm.c_name;
                lblDept.Text = sm.c_dept;
            }
        }
    }
}