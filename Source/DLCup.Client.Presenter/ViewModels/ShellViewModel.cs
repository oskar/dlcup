using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;

namespace DLCup.Client.Presenter.ViewModels
{
    public class ShellViewModel : NotificationObject
    {
        private NotificationObject _selectedView;
        private CupViewModel _cupView;

        public ShellViewModel()
        {
            _cupView = new CupViewModel();

            ShowCupViewCommand = new DelegateCommand(ExecuteShowCupView);

            ExecuteShowCupView();
        }

        public DelegateCommand ShowCupViewCommand { get; private set; }

        public NotificationObject SelectedView
        {
            get { return _selectedView; }
            set
            {
                if (value != _selectedView)
                {
                    _selectedView = value;
                    RaisePropertyChanged(() => SelectedView);
                }
            }
        }

        private void ExecuteShowCupView()
        {
            _cupView.SetCupIdAndStartRefreshData(1); // TODO
            SelectedView = _cupView;
        }
    }
}
