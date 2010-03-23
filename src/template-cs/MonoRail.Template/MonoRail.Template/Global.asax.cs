using System;
using System.Web;
using Castle.MonoRail.Framework.Routing;

namespace MonoRail.Template
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RoutingModuleEx.Engine);
        }

        private static void RegisterRoutes(IRoutingRuleContainer rules)
        {
            rules.Add(new PatternRoute("root", "/")
                          .DefaultForController().Is("Home")
                          .DefaultForAction().Is("Index"));
            rules.Add(new PatternRoute("standard", "[controller]/[action]/[id]")
                          .DefaultForController().Is("Home")
                          .DefaultForAction().Is("Index"));
        }
    }
}