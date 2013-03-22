﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace NMS.SubscriptionService.Plugins.Interfaces
{
    public interface IControllerAbstractFactory
    {
        IController GetFactoryController(RequestContext requestContext, Type controllerType);
    }
}
