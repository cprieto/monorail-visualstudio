using System;
using Castle.MonoRail.Framework;

namespace $safeprojectname$
{
    [Layout("Default"), Rescue("500")]
    public class HomeController : SmartDispatcherController
    {
        public void Index()
        {
            PropertyBag["message"] = "Welcome to Castle MonoRail!";
        }

        public void About()
        {
        }
    }
}