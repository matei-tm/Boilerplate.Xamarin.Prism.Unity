using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaPrisUnit.Services;
using Prism.Commands;
using Prism.Common;
using Prism.Modularity;
using Prism.Navigation;
using Prism.Services;

namespace XamaPrisUnit.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private IModuleManager moduleManager;
        INavigationService navigationService;
        private IBatteryService batteryService;
        IPageDialogService pageDialogService;

        public ICommand GetBatteryStatusCommand { get; set; }

        public bool AllFieldsAreValid { get; set; } = true;

        public HomePageViewModel(
            IModuleManager moduleManager,
            INavigationService navigationService,
            IBatteryService batteryService,
            IPageDialogService pageDialogService) : base(navigationService)
        {
            this.moduleManager = moduleManager;
            this.navigationService = navigationService;
            this.batteryService = batteryService;
            this.pageDialogService = pageDialogService;

            GetBatteryStatusCommand = new DelegateCommand(GetBatteryStatus).ObservesCanExecute(() => AllFieldsAreValid);
        }

        async void GetBatteryStatus()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                await navigationService.NavigateAsync(new Uri("LoginPage", UriKind.Relative));
                return;
            }
            var batteryStatus = batteryService.GetBatteryStatus();
            await pageDialogService.DisplayAlertAsync("Battery Status", batteryStatus, "Ok");
        }
    }
}
