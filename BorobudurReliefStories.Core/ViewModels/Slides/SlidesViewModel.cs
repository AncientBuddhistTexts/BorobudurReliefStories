namespace BorobudurReliefStories.Core.ViewModels.Slides
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.Services;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;

    public class SlidesViewModel : MvxViewModel<(string StoryId, string InitialChapterId)>
    {
        private readonly IMapper _mapper;
        private readonly IMvxNavigationService _navigationService;
        private readonly IStoriesRepository _storiesRepository;
        private string _storyId;
        private string _initialChapterId;

        public ObservableCollection<SlideViewModel> Slides { get; } = new ObservableCollection<SlideViewModel>();

        public SlidesViewModel(IMapper mapper, IMvxNavigationService navigationService, IStoriesRepository storiesRepository)
        {
            _mapper = mapper;
            _navigationService = navigationService;
            _storiesRepository = storiesRepository;
        }

        public override void Prepare((string StoryId, string InitialChapterId) parameter)
        {
            (_storyId, _initialChapterId) = parameter;
            Slides.Clear();

            _ = _storiesRepository
                .GetChapters(_storyId)
                .SelectMany(c => CreateSlidesForChapter(_storyId, c))
                .Reverse()
                .Select(_mapper.Map<SlideViewModel>)
                .Aggregate(Slides, (acc, e) => { acc.Add(e); return acc; });

            _ = _initialChapterId;
        }

        public async Task ClosePageAsync()
        {
            await _navigationService.Close(this);
        }

        private IEnumerable<Slide> CreateSlidesForChapter(string storyId, Chapter c)
        {
            var chapterSlide = new[] { new Slide { Name = c.Name } };
            var slides = _storiesRepository.GetSlides(storyId, c.Id);

            return chapterSlide.Concat(slides);
        }
    }
}
