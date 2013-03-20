using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WURFL;

namespace NMS.SubscriptionService
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class DeviceFilter : ActionFilterAttribute
    {
        public DeviceFilter()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var wurflManager = HttpContext.Current.Cache[WebApiApplication.WurflManagerCacheKey] as IWURFLManager;
            var device = wurflManager.GetDeviceForRequest(filterContext.HttpContext.Request.UserAgent);
            var os = device.GetCapability("device_os");

            /*switch (getOSDevice(filterContext.HttpContext.Request.UserAgent))
            {
                case DeviceOS.Android:
                    break;
                case DeviceOS.iOS:
                    break;
                case DeviceOS.WindowsPhone:
                    break;
                case DeviceOS.unknow:
                    break;
                default:
                    break;
            }*/
            
        }

        /*private DeviceOS getOSDevice(string useragent)
        {

            return DeviceOS.Android;
            //return DeviceOS.iOS;
            //return DeviceOS.WindowsPhone;
            //return DeviceOS.unknow;
        }*/

    }
}