using book_reading_event.Controllers;
using book_reading_event.Models;
using BusinessLayer.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace book_reading_event
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
             container.RegisterType<IEventMaster, EventMaster>();
            container.RegisterType<IEvent1, Event1>();


            container.RegisterType<AccountController>(new InjectionConstructor());



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}