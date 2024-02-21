using System;
using System.Windows;
using System.Windows.Input;
using DeviceManagement.Commands;

namespace DeviceManagement.ViewModel
{
    class ImportFormViewModel : BaseViewModel
    {
        private string? exporter;
        public string? Exporter
        {
            get => exporter;
            set => SetProperty(ref exporter, value);
        }

        private string? company;
        public string? Company
        {
            get => company;
            set => SetProperty(ref company, value);
        }

        private DateTime importDate;
        public DateTime ImportDate
        {
            get => importDate;
            set => SetProperty(ref importDate, value);
        }

        public ICommand ConfirmCommand { get; }

        public ImportFormViewModel()
        {
            ConfirmCommand = new RelayCommand<object>(o => true, o => Confirm());
            ImportDate = DateTime.Now;
        }

        public void Confirm()
        {
            MessageBox.Show(Convert.ToString(ImportDate));
        }
    }
}
