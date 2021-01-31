namespace BorobudurReliefStories.Core.ViewModels.Slides
{
    using System.Collections.Generic;
    using System.Linq;
    using MvvmCross.ViewModels;

    public class SlidesViewModel : MvxViewModel
    {
        public IEnumerable<SlideViewModel> Stories { get; set; } = Enumerable.Empty<SlideViewModel>();
    }
}
