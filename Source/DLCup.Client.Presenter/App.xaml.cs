using System.Windows;

namespace DLCup.Client.Presenter
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();

            ShutdownMode = ShutdownMode.OnMainWindowClose;
        }
    }
}
