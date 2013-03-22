using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NMS.SubscriptionService.Plugins.Interfaces;
using StructureMap;
using WURFL;

namespace NMS.SubscriptionService
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        private IControllerAbstractFactory abstractFactoryController;

        public StructureMapControllerFactory(IControllerAbstractFactory abstractFactoryController)
        {
            this.abstractFactoryController = abstractFactoryController;
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return abstractFactoryController.GetFactoryController(requestContext, controllerType);
        }
    }
}