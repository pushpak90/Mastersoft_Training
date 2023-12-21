using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class finial : System.Web.UI.Page
    {
        SqlConnection _conn;
        SqlCommand _command;
        SqlDataReader _reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string path = ConfigurationManager.AppSettings["BioDB"];
                _conn = new SqlConnection(path);
                _conn.Open();

                string table1 = "SELECT * FROM BasicInfoDB WHERE Id = @Id1";
                _command = new SqlCommand(table1, _conn);
                _command.Parameters.AddWithValue("@Id1", (string)Session["g_id"]);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    lblName.Text = _reader["Name"].ToString();
                    lblEmail.Text = _reader["Email"].ToString();
                    lblMobile.Text = _reader["Mobile"].ToString();
                    lblCity.Text = _reader["City"].ToString();
                    lblAddress.Text = _reader["Address"].ToString();
                    lblpin.Text = _reader["Pincode"].ToString();
                    Image1.ImageUrl = "~/upload/"+_reader["upload"].ToString();
                }
                else
                {
                    Response.Write("Record not avaiable");
                }
                _reader.Close();

                string table4 = "SELECT * FROM Obj WHERE Id = @Id2";
                _command = new SqlCommand(table4, _conn);
                _command.Parameters.AddWithValue("@Id2", (string)Session["g_id"]);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    lblObj.Text = _reader["obj"].ToString();
                }
                else
                {
                    Response.Write("Record not avaiable");
                }
                _reader.Close();

                string table2 = "SELECT * FROM EduInfoDB WHERE Id = @Id3";
                _command = new SqlCommand(table2, _conn);
                _command.Parameters.AddWithValue("@Id3", (string)Session["g_id"]);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    lblUgname.Text = _reader["Ugname"].ToString();
                    lblPgname.Text = _reader["PgName"].ToString();
                    lblYop.Text = _reader["YOP"].ToString();
                }
                else
                {
                    Response.Write("Record not avaiable");
                }
                _reader.Close();

                string table_3 = "SELECT * FROM Exp WHERE Id = @Id5";
                _command = new SqlCommand(table_3, _conn);
                _command.Parameters.AddWithValue("@Id5", (string)Session["g_id"]);
                _reader = _command.ExecuteReader();

                if(_reader.Read())
                {
                    lblYear.Text = _reader["YOE"].ToString();
                    lblComp.Text = _reader["Namecomp"].ToString();
                    lblJdate.Text = _reader["Dateofj"].ToString();
                    lblOther.Text = _reader["Otherexp"].ToString();
                }
            }
        }
    }
}