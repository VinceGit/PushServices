using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NMS.SubscriptionService.Controllers;
using NMS.SubscriptionService.Plugins.Interfaces;
using StructureMap;
using WURFL;

namespace NMS.SubscriptionService.Modules.Concretes
{
    public class StructureMapFactoryManager : IControllerAbstractFactory
    {
        #region Implentation IControllerAbstractFactory
        public IController GetFactoryController(RequestContext requestContext, Type controllerType)
        {
            try
            {
                if (requestContext == null || controllerType == null)
                    return new SuscriptionController(ObjectFactory.GetInstance<DefaultSuscriptionDevice>());

                var wurflManager = HttpContext.Current.Cache[WebApiApplication.WurflManagerCacheKey] as IWURFLManager;
                var device = wurflManager.GetDeviceForRequest(requestContext.HttpContext.Request.UserAgent);
                var os = device.GetCapability("device_os");

                if (Common.DeviceStrategy.ContainsKey(os))
                    return new SuscriptionController((IDeviceStrategy)ObjectFactory.GetInstance(Common.DeviceStrategy[os]));

                return new SuscriptionController(ObjectFactory.GetInstance<DefaultSuscriptionDevice>());
            }
            catch (StructureMapException)
            {
                Console.WriteLine("exception: "+ObjectFactory.WhatDoIHave());
                throw new Exception(ObjectFactory.WhatDoIHave());
            }
        }
        #endregion
    }
}