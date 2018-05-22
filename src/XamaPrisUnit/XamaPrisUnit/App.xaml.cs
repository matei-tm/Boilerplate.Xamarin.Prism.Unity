using Prism;
using Prism.Ioc;
using Prism.Unity;
using Prism.Modularity;
using Xamarin.Forms;
using XamaPrisUnit.Views;
using XamaPrisUnit.ViewModels;
using System;
using AuthenticationModule;

namespace XamaPrisUnit
{
	public partial class App : PrismApplication
	{
        public App() : this(null) { }
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
			InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/HomePage");

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            Type authenticationModuleType = typeof(AuthenticationModule.AuthenticationModule);
            moduleCatalog.AddModule(
             new ModuleInfo(authenticationModuleType)
             {
                 ModuleName = authenticationModuleType.Name,
                 InitializationMode = InitializationMode.WhenAvailable
             });
        }
    }
}
