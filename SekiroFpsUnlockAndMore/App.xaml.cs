using System.Windows;

namespace SekiroFpsUnlockAndMore
{
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            bool quietMode = (e.Args.Length == 1) && (e.Args[0] == "/q");
            new MainWindow(quietMode).Show();
        }
    }
}
