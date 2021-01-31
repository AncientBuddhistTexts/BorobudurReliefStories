namespace BorobudurReliefStories.Core.ViewModels.Slides
{
    using System;
    using MvvmCross.ViewModels;

    public class SlideViewModel : MvxViewModel
    {
        public Uri Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

    }
}
