﻿using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string Submit(string firstName, string lastName)
        {
            UserBO bo = new UserBO();
            UserBL bl = new UserBL();
            string msg = string.Empty;
            try
            {
                bo.firstName = firstName;
                bo.lastName = lastName;

                msg = bl.controllerSubmit(bo);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<UserBO> bindTable()
        {
            string msg = string.Empty;
            List<UserBO> li = new List<UserBO>();
            UserBL bl = new UserBL();
            try
            {
                DataSet ds = new DataSet();
                ds = bl.controllerBindTable();

                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    li = (from DataRow dr in ds.Tables[0].Rows
                          select new UserBO
                          {
                              firstName = dr[0].ToString(),
                              lastName = dr[1].ToString(),
                              city = dr[2].ToString(),
                              mobile = dr[3].ToString(),
                          }).ToList();
                }

                msg = "Table";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return li;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string SaveTableData(List<TableData> data)
        {
            // Your logic to process and store the data
            // Convert the List<TableData> to a DataTable or DataSet if needed
            string msg = string.Empty;
            DataSet ds = new DataSet();
            DataTable dataTable = ConvertListToDataTable(data);
            UserBL bl = new UserBL();
            // Now, 'dataTable' contains your data in tabular form

            if (ds == null)
            {
                ds = new DataSet();
            }
            ds.Tables.Add(dataTable);

            msg = bl.saveDataTable(ds);

            return msg;
            // Perform your database or other saving logic here
        }

        // Helper method to convert List to DataTable
        private static DataTable ConvertListToDataTable(List<TableData> data)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("lastName", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("Mobile", typeof(string));

            foreach (var item in data)
            {
                dataTable.Rows.Add(item.Name,item.lastName ,item.City, item.Mobile);
            }

            return dataTable;
        }
    }
    public class TableData
    {
        public string Name { get; set; }
        public string lastName { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
    }
}