namespace BorobudurReliefStories.Core.ViewModels.Stories
{
    using BorobudurReliefStories.Core.Models;
    using MvvmCross.ViewModels;

    public class StoryViewModel : MvxViewModel
    {
        public LocalizedString Name { get; set; }

        public string Author { get; set; }

        public LocalizedString Description { get; set; }
    }
}
