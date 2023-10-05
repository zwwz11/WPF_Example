using Syncfusion.SfSkinManager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjczOTQ5NUAzMjMzMmUzMDJlMzBRWjZycmNZNURDbzNxSzFibmNMOWZWN3dkcTAwWWx2YVBUMlBNU0dQWVhnPQ==");
        }

        private void StartApp(object sender, StartupEventArgs e)
        {
            MainWindow main = new()
            {
                Title = "Main"
            };
            main.Show();
        }
    }
}
