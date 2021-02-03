namespace BorobudurReliefStories.Core.ViewModels.Stories
{
    using System.Threading.Tasks;
    using System.Windows.Input;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.ViewModels.Chapters;
    using MvvmCross.Commands;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;

    public class StoryViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public string Id { get; set; }

        public LocalizedString Name { get; set; }

        public string Author { get; set; }

        public LocalizedString Description { get; set; }

        public ICommand SelectStoryCommand => new MvxCommand(async () => await SelectStoryAsync());

        public StoryViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async Task SelectStoryAsync()
        {
            await _navigationService.Navigate<ChaptersViewModel, string>(Id);
        }
    }
}
