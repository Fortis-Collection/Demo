[assembly: WebActivator.PostApplicationStartMethod(typeof(Demo.Website.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace Demo.Website.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Extensions;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
	using Rocketcore.Search;
	using Fortis.Model;
	using Fortis.Providers;
	using Fortis.Search;
	using Fortis.Mvc.Providers;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
			InitialiseSearch(container);
			InitialiseFortis(container);
        }

		private static void InitialiseSearch(Container container)
		{
			container.Register(typeof(ISearchManager), () => new SearchManager(
					new SearchIndex("sitecore_master_index"),
					new SearchIndex("sitecore_core_index"),
					new SearchIndex("sitecore_web_index")
				), Lifestyle.Singleton);
		}

		private static void InitialiseFortis(Container container)
		{
			// Register Fortis
			container.Register<IItemFactory, ItemFactory>();
			container.Register<IContextProvider, ContextProvider>();
			container.Register<ISpawnProvider, SpawnProvider>();
			container.Register<ITemplateMapProvider, TemplateMapProvider>();
			container.Register<IModelAssemblyProvider, ModelAssemblyProvider>();
			container.Register<IItemSearchFactory, ItemSearchFactory>();

			// Initialise fortis for pipelines and events
			Fortis.Global.Initialise(
				container.GetInstance<ISpawnProvider>(),
				container.GetInstance<IItemFactory>()
			);
		}
    }
}