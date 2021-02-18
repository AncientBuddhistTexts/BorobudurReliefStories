namespace BorobudurReliefStories.Core.ViewModels.LocalePicker
{
    using AutoMapper;
    using BorobudurReliefStories.Core.Services;
    using MvvmCross.ViewModels;

    public class LocalePickerViewModel : MvxViewModel
    {
        private readonly IMapper _mapper;
        private readonly IStoriesRepository _storiesRepository;

        public LocalePickerViewModel(IMapper mapper, IStoriesRepository storiesRepository)
        {
            _mapper = mapper;
            _storiesRepository = storiesRepository;
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
        }
    }
}
