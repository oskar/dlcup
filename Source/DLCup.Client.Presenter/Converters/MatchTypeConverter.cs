using System;
using System.Windows.Data;

namespace DLCup.Client.Presenter.Converters
{
    public class MatchTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var str = value as string;

            switch (str)
            {
                case "S": return "Singel";
                case "D": return "Dubbel";
                default: return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
