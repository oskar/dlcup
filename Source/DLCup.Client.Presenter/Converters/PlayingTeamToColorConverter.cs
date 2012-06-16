using System;
using System.Windows.Data;
using System.Windows.Media;
using DLCup.Common.Model;

namespace DLCup.Client.Presenter.Converters
{
    public class PlayingTeamToColorConverter : IValueConverter
    {
        public SolidColorBrush NoneColor { get; set; }
        public SolidColorBrush HomeTeamColor { get; set; }
        public SolidColorBrush GuestTeamColor { get; set; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is PlayingTeam))
                return NoneColor;

            var team = (PlayingTeam)value;

            switch (team)
            {
                case PlayingTeam.None: return NoneColor;
                case PlayingTeam.HomeTeam: return HomeTeamColor;
                case PlayingTeam.GuestTeam: return GuestTeamColor;
            }

            return NoneColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
