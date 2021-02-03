namespace BorobudurReliefStories.Core.ViewModels.Slides
{
    using System.Collections.ObjectModel;
    using MvvmCross.ViewModels;

    public class SlidesViewModel : MvxViewModel<(string StoryId, string InitialChapterId)>
    {
        public ObservableCollection<SlideViewModel> Slides { get; } = new ObservableCollection<SlideViewModel>();

        public override void Prepare((string StoryId, string InitialChapterId) parameter)
        {
            Slides.Clear();

            System.Diagnostics.Debug.WriteLine($">>>> Initial slide {parameter.InitialChapterId} {parameter.StoryId}.");
        }
    }
}
