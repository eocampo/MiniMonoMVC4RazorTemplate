using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using System.Web.Mvc;

namespace MiniMonoMVC4RazorTemplate
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e) {
            //ViewEngines.Engines.Clear();
            //ViewEngines.Engines.Add(new MonoWebFormViewEngine());
            //ViewEngines.Engines.Add(new MonoRazorViewEngine());

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }

    //public class MonoWebFormViewEngine : WebFormViewEngine
    //{
    //    protected override bool FileExists(ControllerContext controllerContext, string virtualPath) {
    //        return base.FileExists(controllerContext, virtualPath.Replace("~", ""));

    //    }
    //}


    //public class MonoRazorViewEngine : RazorViewEngine
    //{
    //    protected override bool FileExists(ControllerContext controllerContext, string virtualPath) {
    //        return base.FileExists(controllerContext, virtualPath.Replace("~", ""));

    //    }
    //}


}