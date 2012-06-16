using System;
using System.Windows.Threading;
using DLCup.Client.Presenter.Services;
using DLCup.Common.Model;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace DLCup.Client.Presenter.ViewModels
{
    public class CupViewModel : NotificationObject
    {
        private Cup _model;
        private readonly DispatcherTimer _dataTimer;
        private int _cupId;

        public CupViewModel()
        {
            _dataTimer = new DispatcherTimer();
            _dataTimer.Tick += _dataTimer_Tick;
            _dataTimer.Interval = TimeSpan.FromMilliseconds(500);
        }

        private void _dataTimer_Tick(object sender, EventArgs e)
        {
            var dataService = ServiceLocator.Current.GetInstance<IDataService>();
            Model = dataService.GetCup(_cupId);
        }

        public Cup Model
        {
            get { return _model; }
            set
            {
                if (value != _model)
                {
                    _model = value;
                    RaisePropertyChanged(() => Model);
                }
            }
        }

        public int HomeTeamScore
        {
            get
            {
                return 0;
            }
        }

        public int GuestTeamScore
        {
            get
            {
                return 0;
            }
        }

        public void SetCupIdAndStartRefreshData(int id)
        {
            _cupId = id;
            _dataTimer.Start();
        }
    }
}
