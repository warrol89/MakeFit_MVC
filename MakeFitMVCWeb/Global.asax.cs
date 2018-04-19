using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MakeFitMVCWeb.Controllers;

namespace MakeFitMVCWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            
            if(Session!=null)
            Session["start"] = true;
        }

        void Application_Error(Object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            var route = new RouteData();
            route.Values.Add("controller", "home");
            route.Values.Add("action", "Error");
            route.Values.Add("exception", exception);
            Response.TrySkipIisCustomErrors = true;
            IController controller = new HomeController();
            controller.Execute(new RequestContext(new HttpContextWrapper(Context), route));
            Response.End();

        }
    }
}
