﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Interno : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usuarioLog"] != null)
            {
                string usuarioLog = Session["usuarioLog"].ToString();
            }
            else
            {
                Response.Redirect("~/Index.aspx");
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("usuarioLog");
            Response.Redirect("~/Index.aspx");
        }
    }
}