using Prism.Modularity;
using AuthenticationModule.ViewModels;
using AuthenticationModule.Views;
using System;
using Prism.Ioc;

namespace AuthenticationModule
{
    public class AuthenticationModule : IModule
    {
        public void Initialize() { }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //todo  containerProvider.Resolve<ISomeService>();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
        }
    }
}
