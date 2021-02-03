namespace BorobudurReliefStories.Core.ViewModels.Chapters
{
    using System.Threading.Tasks;
    using System.Windows.Input;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.ViewModels.Slides;
    using MvvmCross.Commands;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;

    public class ChapterViewModel : MvxViewModel<string>
    {
        private readonly IMvxNavigationService _navigationService;
        private string _chapterId;

        public string Id { get; set; }

        public LocalizedString Name { get; set; }

        public ICommand SelectChapterCommand => new MvxCommand(async () => await SelectChapterAsync());

        public ChapterViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Prepare(string parameter)
        {
            _chapterId = parameter;
        }

        public async Task ClosePageAsync()
        {
            await _navigationService.Close(this);
        }

        private async Task SelectChapterAsync()
        {
            await _navigationService.Navigate<SlidesViewModel, (string StoryId, string InitialChapterId)>((Id, _chapterId));
        }
    }
}
