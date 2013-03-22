using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMS.SubscriptionService.Plugins.Interfaces
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=true)]
    public class OsDeviceAttribute : Attribute
    {
        private string name;
        private string version;

        public OsDeviceAttribute(string name, string version)
        {
            this.name = name;
            this.version = version;
        }

        public string Name
        {
            get { return this.name; }
        }
        public string Version
        {
            get { return this.version; }
        }
    }
}
