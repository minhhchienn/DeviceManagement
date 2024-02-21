using System.Windows.Input;
using DeviceManagement.View;
using DeviceManagement.Commands;

namespace DeviceManagement.ViewModel
{
    public class ImportViewModel : BaseViewModel
    {
        public ICommand ImportCommand { get; }

        public ImportViewModel()
        {
            ImportCommand = new RelayCommand<object>(o => true, o => Import());
        }

        public void Import()
        {
            ImportForm importForm = new ();
            importForm.Show();
        }
    }
}
