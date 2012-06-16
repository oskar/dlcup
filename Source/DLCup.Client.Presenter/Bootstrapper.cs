using System.Windows;
using DLCup.Client.Presenter.Services;
using DLCup.Client.Presenter.Views;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;

namespace DLCup.Client.Presenter
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<ShellView>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (ShellView)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            // registers some core prism services
            base.ConfigureContainer();

            // register our own services
            Container.RegisterType<IDataService, DataService>(new ContainerControlledLifetimeManager());
        }
    }
}
