namespace BorobudurReliefStories.UI.Services
{
    using BorobudurReliefStories.Core.Services;
    using Xamarin.Essentials;

    public sealed class AppSettingsService : IAppSettingsService
    {
        public string Load(string key, string defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public void Save(string key, string value)
        {
            Preferences.Set(key, value);
        }
    }
}
