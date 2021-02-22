namespace BorobudurReliefStories.Core.ViewModels.LocalePicker
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using BorobudurReliefStories.Core.Services;
    using BorobudurReliefStories.Core.ViewModels.Stories;
    using MvvmCross.Commands;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;

    public class LocalePickerViewModel : MvxViewModel
    {
        private const string SelectedColor = "accent";
        private const string UnselectedColor = "default";
        private const string DefaultLocale = "id";
        private const string DefaultLocaleSettingsKey = "locale";
        private readonly IMvxNavigationService _navigationService;
        private readonly IAppSettingsService _appSettings;
        private string _locale;

        public string IdButtonBackgroundColor => _locale == "id" ? SelectedColor : UnselectedColor;

        public string EnButtonBackgroundColor => _locale == "en" ? SelectedColor : UnselectedColor;

        public ICommand IdButtonPressed => new MvxCommand(async () => await SaveLocaleAndProceedToStoriesPageAsync("id")());

        public ICommand EnButtonPressed => new MvxCommand(async () => await SaveLocaleAndProceedToStoriesPageAsync("en")());

        public LocalePickerViewModel(IMvxNavigationService navigationService, IAppSettingsService appSettings)
        {
            _navigationService = navigationService;
            _appSettings = appSettings;
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();

            _locale = _appSettings.Load(DefaultLocaleSettingsKey, DefaultLocale);
            RaisePropertyChanged(() => IdButtonBackgroundColor);
            RaisePropertyChanged(() => EnButtonBackgroundColor);
        }

        private Func<Task> SaveLocaleAndProceedToStoriesPageAsync(string locale)
        {
            return async () =>
            {
                _locale = locale;
                _appSettings.Save(DefaultLocaleSettingsKey, _locale);
                await _navigationService.Navigate<StoriesViewModel>();
            };
        }
    }
}
