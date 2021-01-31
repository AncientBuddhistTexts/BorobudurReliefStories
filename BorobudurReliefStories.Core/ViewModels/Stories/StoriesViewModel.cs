namespace BorobudurReliefStories.Core.ViewModels.Stories
{
    using System.Collections.Generic;
    using System.Linq;
    using MvvmCross.ViewModels;

    public class StoriesViewModel : MvxViewModel
    {
        public IEnumerable<StoryViewModel> Stories { get; set; } = Enumerable.Empty<StoryViewModel>();
    }
}
