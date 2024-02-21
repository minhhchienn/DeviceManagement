using System;
using System.Windows.Input;
using DeviceManagement.Services;
using System.Threading.Tasks;
using DeviceManagement.Commands;
using DeviceManagement.Model;
using System.Windows;

namespace DeviceManagement.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string? loginUsername;
        private string? loginPassword;
        private string? loginInfo;

        public string? LoginUsername
        {
            get => loginUsername;
            set => SetProperty(ref loginUsername, value);
        }
        public string? LoginPassword
        {
            get => loginPassword;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Mật khẩu không được để trống");
                SetProperty(ref loginPassword, value);
            }
        }
        public string? LoginInfo
        {
            get => loginInfo;
            set => SetProperty(ref loginInfo, value);
        }

        public ICommand? LoginCommand { get; }

        private readonly IAccountService? accountService;

        public LoginViewModel() { }

        public LoginViewModel(IAccountService accountService)
        {
            LoginCommand = new AsyncCommand(async () => await Login());
            this.accountService = accountService;
        }

        public async Task Login()
        {
            if (LoginUsername == null || LoginPassword == null)
            {
                LoginInfo = "Chưa nhập đủ tên tài khoản hoặc mật khẩu";
                return;
            }
            if (accountService == null)
            {
                LoginInfo = "Không thể kết nối tới csdl";
                return;
            }
            var acc = await accountService.GetAccountByUsernameAndPassword(LoginUsername, LoginPassword);
            if (acc != null)
            {
                Repository.LoggedAccount = acc;
                App.Instance.ShowMainWindow();
            }
            else
            {
                LoginInfo = "Tên tài khoản hoặc mật khẩu không chính xác.";
            }
        }
    }
}
