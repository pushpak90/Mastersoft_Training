﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class controller
    {
        public object DROP()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5O2IMF80;Initial Catalog=Machine_Test;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand com = new SqlCommand("select BranchID, BranchName from Branch", con);

            com.CommandType = CommandType.Text;
            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(ds);

            return ds;
        }

        public DataSet table()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5O2IMF80;Initial Catalog=Machine_Test;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand com = new SqlCommand("select ID, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 from SampleTable", con);

            com.CommandType = CommandType.Text;
            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(ds);

            return ds;
        }
    }
}