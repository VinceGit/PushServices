using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NMS.SubscriptionService.Plugins.Interfaces;

namespace NMS.SubscriptionService.Controllers
{
    public class SuscriptionController : Controller
    {
        private IDeviceStrategy suscriptionDevice;

        public SuscriptionController(IDeviceStrategy suscriptionDevice)
        {
            this.suscriptionDevice = suscriptionDevice;
        }

        //ToDo: voir pour mettre de facon générique les action d'appel en fonction du plugin
        /*protected override IActionInvoker CreateActionInvoker()
        {
             return base.CreateActionInvoker();
        }*/

        //[HttpPost]
        public void Register()
        {
            this.suscriptionDevice.Register(Request);
        }

        //[HttpPost]
        public void Unregister()
        {
            this.suscriptionDevice.Unregister(Request);
        }
    }
}
