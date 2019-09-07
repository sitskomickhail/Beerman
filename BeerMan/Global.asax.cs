using BeerMan.Controllers;
using BeerMan.Models;
using Ninject;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BeerMan
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<BeermanContext>().To<BeermanContext>();
            kernel.Bind<WalletController>().To<WalletController>();
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));            


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
