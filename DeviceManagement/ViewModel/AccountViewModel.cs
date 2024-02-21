using System.Windows.Input;
using DeviceManagement.Model;
using DeviceManagement.Commands;

namespace DeviceManagement.ViewModel
{
    public class AccountViewModel : BaseViewModel
    {
        private BaseViewModel? currentViewModel;
        public BaseViewModel? CurrentViewModel
        {
            get { return currentViewModel; }
            set { currentViewModel = value; OnPropertyChanged(); }
        }

        public ICommand? ProfileCommand { get; }
        public ICommand? SecurityCommand { get; }

        private Account? currentAccount;
        public Account? CurrentAccount
        {
            get => currentAccount;
            set => currentAccount = value;
        }

        public AccountViewModel()
        {
            ProfileCommand = new RelayCommand<object>(o => true, o => ProfileViewShow());
            SecurityCommand = new RelayCommand<object>(o => true, o => SecurityViewShow());

            //Startup View
            CurrentViewModel = new ProfileViewModel();
        }

        public void ProfileViewShow() => CurrentViewModel = new ProfileViewModel();
        public void SecurityViewShow() => CurrentViewModel = new SecurityViewModel();
    }
}
