using PingYourPackage.API.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace PingYourPackage.API.WebHost
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            var config = GlobalConfiguration.Configuration;

            //RouteConfig.RegisterRoutes(config);
            //WebApiConfig.Configure(config);
            //AutofacWebAPI.Initialize(config);

            EFConfig.Initialize();
        }
    }
}
