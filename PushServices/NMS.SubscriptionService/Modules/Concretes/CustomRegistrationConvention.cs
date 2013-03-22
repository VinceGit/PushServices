using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NMS.SubscriptionService.Plugins.Interfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap;

namespace NMS.SubscriptionService.Modules.Concretes
{
    /*public class CustomTypeScanner : ITypeScanner
    {
        public void Process(Type type, PluginGraph graph)
        {
            if(type.GetInterfaces().Contains(typeof(IDeviceStrategy)))
            {
                graph.AddType(typeof(IDeviceStrategy), type);
                Common.DeviceStrategy.Add(type.Name, type);
            }
        }
    }*/

    public class CustomRegistrationConvention : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            if (type.GetInterfaces().Contains(typeof(IDeviceStrategy)))
            {
                registry.AddType(typeof(IDeviceStrategy), type);

                foreach (Attribute attr in Attribute.GetCustomAttributes(type))
                    if (attr is OsDeviceAttribute)
                        Common.DeviceStrategy.Add(((OsDeviceAttribute)attr).Name, type);
            }
        }
    }
}