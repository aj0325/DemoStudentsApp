namespace Demo.DemoCBIA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("syncfusionkey");
            MainPage = new AppShell();
        }
    }
}