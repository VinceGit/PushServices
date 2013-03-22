using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NMS.SubscriptionService.Plugins.Interfaces;

namespace NMS.SubscriptionService.Modules.Concretes
{
    [OsDevice("Android",null)]
    [OsDevice("Android2",null)]
    public class AndroidSuscriptionDevice : IDeviceStrategy
    {
        public void Register(System.Web.HttpRequestBase request)
        {
            string regId = request.Params["regId"];
            if (string.IsNullOrEmpty(regId))
                throw new ArgumentNullException();
            Console.WriteLine("Android register id: " + regId);
        }

        public void Unregister(System.Web.HttpRequestBase request)
        {
            string regId = request.Params["regId"];
            if (string.IsNullOrEmpty(regId))
                throw new ArgumentNullException();
            Console.WriteLine("Android Unregister id: " + regId);
        }
    }
}