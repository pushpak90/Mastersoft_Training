using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class UserDA
    {
        SqlConnection _conn = new SqlConnection(ConfigurationManager.AppSettings["mdb"]);
        public string login(UserBO ob)
        {
            _conn.Open();
            SqlCommand com = new SqlCommand("User_Login", _conn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("UserName1", ob.Username);
            com.Parameters.AddWithValue("Password1", ob.Password);

            SqlDataReader dr = com.ExecuteReader();

            if(dr.Read())
            {
                if (dr["UserName"].ToString() == ob.Username && dr["Password"].ToString() == ob.Password)
                {
                    return "StudentReg.aspx";
                }
            }
            else
            {
                return "Invalid";
            }

            return "Error";
        }

        public object ddldeg()
        {
            _conn.Open();
            SqlCommand com = new SqlCommand("ddl_d", _conn);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader dr = com.ExecuteReader();

            return dr;
        }

        public object ddlbranch(UserBO ob)
        {
            int degid = 0;
            _conn.Open();
            SqlCommand com = new SqlCommand("select * from Degree WHERE DegreeName = @DName1", _conn);
            
            com.Parameters.AddWithValue("DName1", ob.Sel_deg);
            SqlDataReader dr1 = com.ExecuteReader();

            if(dr1.Read())
            {
                degid = int.Parse(dr1["DegreeId"].ToString());
            }
            dr1.Close();



            SqlCommand cmd = new SqlCommand("ddl_b", _conn);
            //SELECT * FROM Branch where DegreeID = @deId;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("deId", degid);

            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        
        public string stu_sub(UserBO ob)
        {
            _conn.Open();
            SqlCommand com = new SqlCommand("insert_data", _conn);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("Name1",ob.sName);
            com.Parameters.AddWithValue("DOB1", ob.DOB);
            com.Parameters.AddWithValue("Gender1", ob.Gender);
            com.Parameters.AddWithValue("Degree1", ob.Degree);
            com.Parameters.AddWithValue("Branch1", ob.Branch);
            com.Parameters.AddWithValue("Email1", ob.Email);
            com.Parameters.AddWithValue("Mobile1", ob.Mobile);
            com.Parameters.AddWithValue("Photo1", ob.Upload);
            com.Parameters.AddWithValue("Status1", ob.Check);
            
            com.ExecuteNonQuery();
            
            return com.ToString();

        }

        public object show_grid()
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM stu_info", _conn);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        public string del_rec(UserBO bo)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM stu_info WHERE Name = @Name1 and Gender = @Gender1",_conn);
            cmd.Parameters.AddWithValue("Name1", bo.sName);
            cmd.Parameters.AddWithValue("Gender1", bo.Gender);

            cmd.ExecuteNonQuery();
            return "Done";
            
        }

        public string update_rec(UserBO bo)
        {
            string email, phone;
            _conn.Open();
            SqlCommand cmd = new SqlCommand("update_select_rec", _conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Name1", bo.sName);
            cmd.Parameters.AddWithValue("Gender1", bo.Gender);
            cmd.Parameters.AddWithValue("Degree1", bo.Degree);
            cmd.Parameters.AddWithValue("Branch1", bo.Branch);
            cmd.Parameters.AddWithValue("DOB1", bo.DOB);
            cmd.Parameters.AddWithValue("Photo1", bo.Upload);

            SqlDataReader dr = cmd.ExecuteReader();

            return "Inserted";
        }
    }
}
