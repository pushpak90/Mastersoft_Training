﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Access Session
            //Control = (String)Session["email"];
            Label1.Text = (string)Session["email"];
            Label2.Text = (string)Session["mobile"];
        }
    }
}