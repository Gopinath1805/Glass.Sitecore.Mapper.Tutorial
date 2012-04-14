﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Glass.Sitecore.Mapper.Tutorial
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var loader = new Glass.Sitecore.Mapper.Configuration.Attributes.AttributeConfigurationLoader(
                    "Glass.Sitecore.Mapper.Tutorial.Models, Glass.Sitecore.Mapper.Tutorial");

            Glass.Sitecore.Mapper.Context context = new Context(loader);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}