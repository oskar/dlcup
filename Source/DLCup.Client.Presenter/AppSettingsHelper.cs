using System;
using System.Configuration;

namespace DLCup.Client.Presenter
{
    public static class AppSettingsHelper
    {
        /// <summary>
        /// Gets the configuration value for the supplied key and converts to
        /// requested type if exists, otherwise the value of the parameter
        /// defaultValue is returned.
        /// </summary>
        /// <param name="key"> The key used to look up configuration value. </param>
        /// <returns></returns>
        public static T GetValue<T>(string key, T defaultValue)
        {
            var value = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(value))
                return defaultValue;

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
