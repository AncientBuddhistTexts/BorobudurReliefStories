namespace BorobudurReliefStories.Core.ViewModels.Slides
{
    using BorobudurReliefStories.Core.Models;
    using MvvmCross.ViewModels;

    public class SlideViewModel : MvxViewModel
    {
        public bool IsAChapterHeader => Path == null;

        public bool IsASlide => !IsAChapterHeader;

        public string Path { get; set; }

        public LocalizedString Name { get; set; }

        public LocalizedString Caption { get; set; }
    }
}
