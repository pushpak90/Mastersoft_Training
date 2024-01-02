using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Web.Services.Description;
using System.Net.Configuration;
using System.IO;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                fetch_grid();
            }
        }

        protected void fetch_grid()
        {
            string path = "Data Source=LAPTOP-5O2IMF80;Initial Catalog=College;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(path);
            conn.Open();

            string query = "SELECT * FROM old_student";
            cmd = new SqlCommand(query, conn);

            reader = cmd.ExecuteReader();
            
            GridView1.DataSource = reader;
            GridView1.DataBind();

            reader.Close();

        }

        protected void btnEmail_Click(object sender, EventArgs e)
        {


            StringWriter sw = new StringWriter();
            HtmlTextWriter writer = new HtmlTextWriter(sw);

            
            foreach (GridViewRow row in GridView1.Rows)
            {
                row.RenderControl(writer);
            }




            MailMessage msg = new MailMessage();
            //set the mail property
            msg.To.Add(txtemail.Text);
            msg.From = new MailAddress("pfasate47@gmail.com");
            msg.Subject = "This is testing Mail";
            msg.Body = "Welcome this is Grid mail";

            //set html format = "True"
            msg.IsBodyHtml = true;

            //using SMTP clinet Object
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("pfasate47@gmail.com", "gwcq cuqk adrd xcjm");
            //smtp.Credentials = new System.Net.NetworkCredential("pfasate47@gmail.com", "tyes iypy mreu etfj");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;

            //Send mail
            smtp.Send(msg);


        }
    }
}