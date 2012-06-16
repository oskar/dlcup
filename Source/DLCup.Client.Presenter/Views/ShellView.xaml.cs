using System.Windows;
using DLCup.Client.Presenter.ViewModels;
using Microsoft.Practices.Unity;

namespace DLCup.Client.Presenter.Views
{
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
        }

        [Dependency]
        public ShellViewModel ViewModel
        {
            get { return this.DataContext as ShellViewModel; }
            set { this.DataContext = value; }
        }
    }
}
