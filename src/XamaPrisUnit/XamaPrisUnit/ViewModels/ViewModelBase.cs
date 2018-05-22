using Prism.Mvvm;
using Prism.Navigation;

namespace XamaPrisUnit.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }

        protected INavigationService NavigationService { get; private set; }

        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("UserName"))
            {
                UserName = parameters.GetValue<string>("UserName");
            }
        }

        public virtual void Destroy()
        {

        }
    }
}
