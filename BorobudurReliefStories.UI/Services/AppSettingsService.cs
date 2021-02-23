namespace BorobudurReliefStories.UI.Services
{
    using BorobudurReliefStories.Core.Services;
    using Xamarin.Essentials;

    public sealed class AppSettingsService : IAppSettingsService
    {
        private const string DefaultLocale = "id";
        private const string LocaleSettingsKey = "locale";

        public string Locale
        {
            get => Preferences.Get(LocaleSettingsKey, DefaultLocale);
            set => Preferences.Set(LocaleSettingsKey, value);
        }
    }
}
