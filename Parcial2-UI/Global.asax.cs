﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace Parcial2_UI
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/scripts/jquery-3.0.0.min.js",
                DebugPath = "~/scripts/jquery-3.0.0.js",
                CdnPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.0.0.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.0.0.js"
            });
        }
    }
}