using Plugin.Settings;

namespace Xam.Plugins.MySettings
{
    public static class Settings
    {
        public static string MyValue
        {
            get { return CrossSettings.Current.GetValueOrDefault("MyValue", null); }
            set { CrossSettings.Current.AddOrUpdateValue("MyValue", value);  }
        }
    }
}
