using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Threading.Tasks;

namespace AuthenticationModule.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        public DelegateCommand OnLoginCommand { get; set; }
        INavigationService navigationService;
        IPageDialogService pageDialogService;

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }

        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            this.navigationService = navigationService;
            this.pageDialogService = pageDialogService;
            OnLoginCommand = new DelegateCommand(async () => await GoHome());
        }

        async Task GoHome()
        {
            if (string.IsNullOrEmpty(UserName))
                await pageDialogService.DisplayAlertAsync("Error", "UserName is required", "Ok");
            else
                await navigationService.NavigateAsync(new Uri($"HomePage?UserName={UserName}", UriKind.Relative));
        }
    }

}
