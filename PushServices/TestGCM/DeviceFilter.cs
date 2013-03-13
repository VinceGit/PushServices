using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGCM
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class DeviceFilter : ActionFilterAttribute
    {

        //private MyCustomFilterMode _Mode = MyCustomFilterMode.Respect;        // this is the default, so don't always have to specify

        //public MyCustomFilterAttribute()
        //{
        //}
        public DeviceFilter()
        {
            //_Mode = mode;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (_Mode == MyCustomFilterMode.Ignore)
            //{
            //    return;
            //}

            // Otherwise, respect the attribute and work your magic here!
            //
            //
            //
        }

    }
}