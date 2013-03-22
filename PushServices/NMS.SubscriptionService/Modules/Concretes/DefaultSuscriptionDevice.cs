using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NMS.SubscriptionService.Plugins.Interfaces;

namespace NMS.SubscriptionService.Modules.Concretes
{
    public class DefaultSuscriptionDevice : IDeviceStrategy
    {
        public void Register(HttpRequestBase request)
        {
            throw new NotImplementedException();
        }

        public void Unregister(HttpRequestBase request)
        {
            throw new NotImplementedException();
        }
    }
}