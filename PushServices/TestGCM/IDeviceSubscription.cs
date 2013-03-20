using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TestGCM
{
    interface IDeviceSubscription
    {
        [HttpPost]
        void register(string regId);

        [HttpPost]
        void unregister(string regId);
    }
}
