using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NMS.SubscriptionService.Controllers;
using NMS.SubscriptionService.Modules.Concretes;
using NMS.SubscriptionService.Plugins.Interfaces;
using StructureMap;

namespace NMS.SubscriptionService
{
    public static class Bootstrap
    {
        public static void Run()
        {
            //ObjectFactory.Initialize(x => x.For<IDeviceStrategy>().Add<DefaultSuscriptionDevice>());
            ObjectFactory.Initialize(
                x =>
                {
                    x.Scan(scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.AssembliesFromApplicationBaseDirectory();

                        //var a = scan.AddAllTypesOf<IDeviceStrategy>();
                        scan.AddAllTypesOf<IControllerAbstractFactory>();

                        scan.ExcludeType<SuscriptionController>();
                        //scan.With<CustomTypeScanner>();
                        scan.Convention<CustomRegistrationConvention>();

                        scan.WithDefaultConventions();
                    });
                });

            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory((IControllerAbstractFactory)ObjectFactory.GetInstance<IControllerAbstractFactory>()));
        }
    }
}