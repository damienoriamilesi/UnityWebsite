using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MyWebSite.Service;
using Unity.AutoRegistration;
using Unity.Mvc4;

namespace MyWebSite
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterTypes(
            AllClasses.FromLoadedAssemblies(false, false, false, false),
            WithMappings.FromMatchingInterface,
            WithName.Default,
            PerRequest,
            null,
            true);
    }
    public static Func<Type, LifetimeManager> PerRequest = (x) => new PerRequestLifetimeManager();
  }
}