using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGCM.Controllers
{
    [DeviceFilter]
    public class DeviceController : Controller, IDeviceSubscription
    {
        public JsonResult Index()
        {
            return Json(Common.GetAllDevices(), JsonRequestBehavior.AllowGet);
        }

        public void register(string regId)
        {
            throw new Exception("Unknow device");
        }

        public void unregister(string regId)
        {
            throw new Exception("Unknow device");
        }
    }
}
