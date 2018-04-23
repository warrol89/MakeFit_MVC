using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using MakeFitMVCWeb.Controllers;
using MakeFitMVC.Business.Interface;
using MakeFitMVC.Business;

namespace MakeFitMVCWeb
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<ILogin, Login>();
            //container.RegisterType<IController, HomeController>("Home");
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}