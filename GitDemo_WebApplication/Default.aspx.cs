﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitDemo_WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("My First Git Demo Web Application");
            Response.Write("<script language=javascript>alert('done!');</script>");

           
        }
    }
}