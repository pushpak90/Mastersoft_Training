using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Admit_Card
{
    public partial class admit : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Class1 c1 = new Class1();
                c1.admit_card((string)Session["s_enroll"]);

                FormView1.DataSource = c1.dr;
                FormView1.DataBind();
                c1.dr.Close();
            }
        }
    }
}