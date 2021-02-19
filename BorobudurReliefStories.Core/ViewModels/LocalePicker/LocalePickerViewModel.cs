namespace BorobudurReliefStories.Core.ViewModels.LocalePicker
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using BorobudurReliefStories.Core.ViewModels.Stories;
    using MvvmCross.Commands;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;

    public class LocalePickerViewModel : MvxViewModel
    {
        private readonly string _accentColor = "Accent";
        private readonly IMvxNavigationService _navigationService;
        private string _locale = "en";

        public string IdButtonBackgroundColor => _locale == "id" ? _accentColor : null;

        public string EnButtonBackgroundColor => _locale == "en" ? _accentColor : null;

        public ICommand IdButtonPressed => new MvxCommand(async () => await SaveLocaleAndProceedToStoriesPageAsync("id")());

        public ICommand EnButtonPressed => new MvxCommand(async () => await SaveLocaleAndProceedToStoriesPageAsync("en")());

        public LocalePickerViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private Func<Task> SaveLocaleAndProceedToStoriesPageAsync(string locale)
        {
            return async () =>
            {
                _locale = locale;
                await _navigationService.Navigate<StoriesViewModel>();
            };
        }
    }
}
