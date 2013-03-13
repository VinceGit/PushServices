using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGCM.Controllers
{
    [DeviceFilter]
    public class DeviceController : Controller
    {
        //
        // GET: /Register/

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public JsonResult Index()
        {
            return Json(Common.GetAllDevices(), JsonRequestBehavior.AllowGet);
        }

        // POST device
        [HttpPost]
        public void register(string regId)
        {
            Common.AppendDevice(regId);
        }

        [HttpPost]
        public void unregister(string regId)
        {
            Common.RemoveDevice(regId);
        }

    }
}
