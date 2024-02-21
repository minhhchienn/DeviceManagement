using DeviceManagement.Model;
using System.Windows.Input;
using DeviceManagement.Commands;
using DeviceManagement.Services;

namespace DeviceManagement.ViewModel
{
    public class ProfileViewModel : BaseViewModel
    {
        private readonly IAccountService? accountService;

        private Account? accountInfo;
        public Account AccountInfo
        {
            get => accountInfo;
            set => accountInfo = value;
        }

        private string? name;
        public string? Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string? email;
        public string? Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        private string? position;
        public string? Position
        {
            get => position;
            set => SetProperty(ref position, value);
        }

        private bool isEditingInfo;
        public bool IsEditingInfo
        {
            get => isEditingInfo;
            set => SetProperty(ref isEditingInfo, value);
        }

        private string? editUsername;
        public string? EditUsername
        {
            get => editUsername;
            set => SetProperty(ref editUsername, value);
        }

        public string? editRole;
        public string? EditRole
        {
            get => editRole;
            set => SetProperty(ref editRole, value);
        }

        private string? editName;
        public string? EditName
        {
            get => editName;
            set => SetProperty(ref editName, value);
        }

        private string? editPhoneNumber;
        public string? EditPhoneNumber
        {
            get => editPhoneNumber;
            set => SetProperty(ref editPhoneNumber, value);
        }

        private string? editEmail;
        public string? EditEmail
        {
            get => editEmail;
            set => SetProperty(ref editEmail, value);
        }

        private string? editPosition;
        public string? EditPosition
        {
            get => editPosition;
            set => SetProperty(ref editPosition, value);
        }

        public ICommand? EditInfoCommand { get; }
        public ICommand? ConfirmInfoCommand { get; }
        public ICommand? CancelEditCommand { get; }

        public ProfileViewModel()
        {
            accountService = new MainViewModel().AccountService;
            UpdateData();

            EditInfoCommand = new RelayCommand<object>(o => true, o => EditInfo());
            ConfirmInfoCommand = new RelayCommand<object>(o => true, o => ConfirmInfo());
            CancelEditCommand = new RelayCommand<object>(o => true, o => CancelEdit());
        }

        public void EditInfo() => IsEditingInfo = true;

        public void ConfirmInfo()
        {
            Repository.LoggedAccount.tendangnhap = EditUsername;
            Repository.LoggedAccount.quyen = EditRole;
            Repository.LoggedAccount.email = EditEmail;
            Repository.LoggedAccount.sdt = EditPhoneNumber;
            Repository.LoggedAccount.chucvu = EditPosition;
            Repository.LoggedAccount.hoten = EditName;
            accountService?.UpdateAccountAsync(Repository.LoggedAccount);
            UpdateData();
        }

        public void CancelEdit()
        {
            UpdateData();
            IsEditingInfo = false;
        }

        private void UpdateData()
        {
            AccountInfo = Repository.LoggedAccount;
            Name = AccountInfo.hoten;
            Email = AccountInfo.email;
            Position = AccountInfo.chucvu;
            EditUsername = AccountInfo.tendangnhap;
            EditRole = AccountInfo.quyen;
            EditName = AccountInfo.hoten;
            EditPhoneNumber = AccountInfo.sdt;
            EditEmail = AccountInfo.email;
            EditPosition = AccountInfo.chucvu;
            IsEditingInfo = false;
        }
    }
}
