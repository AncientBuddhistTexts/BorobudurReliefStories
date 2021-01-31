namespace BorobudurReliefStories.Core.ViewModels.Chapters
{
    using System.Collections.Generic;
    using System.Linq;
    using MvvmCross.ViewModels;

    public class ChaptersViewModel : MvxViewModel
    {
        public IEnumerable<ChapterViewModel> Stories { get; set; } = Enumerable.Empty<ChapterViewModel>();
    }
}
