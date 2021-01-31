namespace BorobudurReliefStories.Core.ViewModels.Home
{
    using System.Collections.ObjectModel;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.Services;
    using MvvmCross.ViewModels;

    public class HomeViewModel : MvxViewModel
    {
        private readonly IStoriesRepository _storiesRepository;

        public ObservableCollection<Story> Stories { get; } = new ObservableCollection<Story>();

        public HomeViewModel(IStoriesRepository storiesRepository)
        {
            _storiesRepository = storiesRepository;
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            foreach (var story in _storiesRepository.Load())
            {
                Stories.Add(story);
            }
        }
    }
}
