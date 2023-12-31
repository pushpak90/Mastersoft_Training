using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Student_Complained
{
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dept d1 = new dept();
                d1.read((string)Session["s_email"], (string)Session["s_pass"]);
                txtcode.Text = d1.p_collegeCode;
                txtname.Text = d1.p_colName;
                txtDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            newspage np = new newspage();
            np.news_inser(txtcode.Text, txtname.Text, txtTitle.Text, txtMessage.Text, txtDate.Text);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            newspage np1 = new newspage();
            np1.show_grid();
            GridView1.DataSource = np1.rdr;
            GridView1.DataBind();
            np1.rdr.Close();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtGcolcode = (TextBox)r1.FindControl("txtColcode");
            TextBox txtGcolname = (TextBox)r1.FindControl("txtColname");
            TextBox txtGtitle = (TextBox)r1.FindControl("txtTitle");
            TextBox txtn_mess = (TextBox)r1.FindControl("txtMessage");
            newspage np2 = new newspage();
            np2.edit_grid(txtGcolcode.Text, txtGcolname.Text, txtGtitle.Text, txtn_mess.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtGcolcode = (TextBox)r1.FindControl("txtColcode");
            TextBox txtGcolname = (TextBox)r1.FindControl("txtColname");
            TextBox txtGtitle = (TextBox)r1.FindControl("txtTitle");
            TextBox txtn_mess = (TextBox)r1.FindControl("txtMessage");
            newspage np3 = new newspage();
            np3.del_grid(txtGcolcode.Text, txtGcolname.Text, txtGtitle.Text, txtn_mess.Text);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            GridViewRow r4 = ((Button)sender).NamingContainer as GridViewRow;
            TextBox txtGtitle = (TextBox)r4.FindControl("txtTitle");
            TextBox txtn_mess = (TextBox)r4.FindControl("txtMessage");
            newspage np4 = new newspage();
            np4.footer_insert(txtcode.Text, txtname.Text, txtGtitle.Text, txtn_mess.Text, txtDate.Text);
        }
    }
}