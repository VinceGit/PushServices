using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMS.SubscriptionService
{
    public static class Common
    {
        #region Ne Pas regarder - Verrue
        private static Dictionary<string, Type> deviceStrategy = new Dictionary<string,Type>();
        public static Dictionary<string, Type> DeviceStrategy
        {
            get { return deviceStrategy; }
            private set { }
        }
        #endregion
    }
}