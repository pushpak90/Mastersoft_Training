using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Discovery;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt.Text == "")
                {
                    throw new Exception("Plz enter value");
                }
                else
                {
                    Response.Write("Done");
                }
            }
            catch (Exception ex) 
            {
                Response.Write(ex);
                Response.Write(ex.Message);
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text == "")
                {
                    throw new Exception("Plz enter value 2");
                }
                else
                {
                    Response.Write("Done 2");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
                Response.Write(ex.Message);
            }
        }
    }
}