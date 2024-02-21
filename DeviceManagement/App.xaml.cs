using DeviceManagement.Model;
using DeviceManagement.View;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using DeviceManagement.Services;
using DeviceManagement.ViewModel;

namespace DeviceManagement
{
    public partial class App : Application
    {
        private static App? instance;
        public static App Instance => instance ??= new App();

        private LoginView? loginWindow;
        private MainView? mainWindow;

        private const string connectionString = @"Data Source = localhost; Initial Catalog = DeviceManagement; Integrated Security = True; TrustServerCertificate = True";

        private readonly IServiceProvider serviceProvider;

        public App()
        {
            instance = this;

            serviceProvider = ConfigureServices().BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShowLoginWindow();
        }

        public void ShowLoginWindow()
        {
            loginWindow = new()
            {
                DataContext = serviceProvider.GetService<LoginViewModel>()
            };
            loginWindow.Show();
        }

        public void ShowMainWindow()
        {
            mainWindow = new MainView()
            {
                DataContext = serviceProvider.GetService<MainViewModel>()
            };
            mainWindow.Show();
            loginWindow?.Close();
        }
        
        private static IServiceCollection ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            serviceCollection.AddScoped<IAccountService, AccountService>();
            serviceCollection.AddScoped<IDeviceService, DeviceService>();
            serviceCollection.AddScoped<IImportService, ImportService>();

            serviceCollection.AddSingleton<LoginViewModel>();
            serviceCollection.AddSingleton<MainViewModel>();

            serviceCollection.AddSingleton<Repository>();

            return serviceCollection;
        }
    }
}
