using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessObject;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        UserBL bl = new UserBL();
        UserBO bo = new UserBO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtUserName.Text == "" || txtPassword.Text == "")
                {
                    throw new Exception("All Field are require");
                }
                else
                {
                    bo.Username = txtUserName.Text;
                    bo.Password = txtPassword.Text;

                    string ret = bl.login_da(bo);

                    if (ret == "Invalid")
                    {
                        Response.Write("Invalid");
                    }
                    else if(ret == "Error")
                    {
                        Response.Write("Error");
                    }
                    else
                    {
                        Response.Redirect(ret);
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}