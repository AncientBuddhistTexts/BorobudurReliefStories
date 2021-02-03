namespace BorobudurReliefStories.Core.ViewModels.Stories
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using AutoMapper;
    using BorobudurReliefStories.Core.Services;
    using MvvmCross.ViewModels;

    public class StoriesViewModel : MvxViewModel
    {
        private readonly IMapper _mapper;
        private readonly IStoriesRepository _storiesRepository;

        public ObservableCollection<StoryViewModel> Stories { get; } = new ObservableCollection<StoryViewModel>();


        public StoriesViewModel(IMapper mapper, IStoriesRepository storiesRepository)
        {
            _mapper = mapper;
            _storiesRepository = storiesRepository;
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            Stories.Clear();

            _ = _storiesRepository
                .GetStories()
                .Where(s => s.Enabled)
                .Select(_mapper.Map<StoryViewModel>)
                .Aggregate(Stories, (acc, e) => { acc.Add(e); return acc; });
        }
    }
}
