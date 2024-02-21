using System.ComponentModel.Design;
using System.Windows.Input;
using DeviceManagement.Commands;
using DeviceManagement.Services;

namespace DeviceManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public IAccountService? AccountService { get; set; }
        public IDeviceService? DeviceService { get; set; }
        public IImportService? ImportService { get; set; }

        private BaseViewModel? currentViewModel;
        public BaseViewModel? CurrentViewModel
        {
            get { return currentViewModel; }
            set { currentViewModel = value; OnPropertyChanged(); }
        }

        public ICommand? AccountCommand { get; }
        public ICommand? DeviceCommand { get; }
        public ICommand? ImportCommand { get; }
        public ICommand? ExportCommand { get; }
        public ICommand? GuaranteeCommand { get; }

        public MainViewModel() { }

        public MainViewModel(IDeviceService deviceService, IImportService importService, IAccountService accountService)
        {
            DeviceService = deviceService;
            ImportService = importService;
            AccountService = accountService;

            AccountCommand = new RelayCommand<object>(o => true, o => AccountViewShow());
            DeviceCommand = new RelayCommand<object>(o => true, o => DeviceViewShow());
            ImportCommand = new RelayCommand<object>(o => true, o => ImportViewShow());
            ExportCommand = new RelayCommand<object>(o => true, o => ExportViewShow());
            GuaranteeCommand = new RelayCommand<object>(o => true, o => GuaranteeViewShow());

            //Startup View
            CurrentViewModel = new DeviceViewModel();
        }

        public void AccountViewShow() => CurrentViewModel = new AccountViewModel();
        public void DeviceViewShow() => CurrentViewModel = new DeviceViewModel();
        public void ImportViewShow() => CurrentViewModel = new ImportViewModel();
        public void ExportViewShow() => CurrentViewModel = new ExportViewModel();
        public void GuaranteeViewShow() => CurrentViewModel = new GuaranteeViewModel();
    }
}
