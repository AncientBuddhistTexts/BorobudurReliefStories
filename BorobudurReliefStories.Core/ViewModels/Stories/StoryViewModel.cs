namespace BorobudurReliefStories.Core.ViewModels.Stories
{
    using MvvmCross.ViewModels;

    public class StoryViewModel : MvxViewModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }
    }
}
