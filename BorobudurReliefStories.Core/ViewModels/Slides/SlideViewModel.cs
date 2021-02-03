namespace BorobudurReliefStories.Core.ViewModels.Slides
{
    using System;
    using BorobudurReliefStories.Core.Models;
    using MvvmCross.ViewModels;

    public class SlideViewModel : MvxViewModel
    {
        public bool IsAChapterHeader => Url == null;

        public bool IsASlide => !IsAChapterHeader;

        public Uri Url { get; set; }

        public LocalizedString Name { get; set; }

        public LocalizedString Caption { get; set; }
    }
}
