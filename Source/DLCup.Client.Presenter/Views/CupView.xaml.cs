using System.Windows.Controls;
using DLCup.Client.Presenter.ViewModels;
using Microsoft.Practices.Unity;

namespace DLCup.Client.Presenter.Views
{
    public partial class CupView : UserControl
    {
        public CupView()
        {
            InitializeComponent();
        }

        [Dependency]
        public CupViewModel ViewModel
        {
            get { return this.DataContext as CupViewModel; }
            set { this.DataContext = value; }
        }
    }
}
