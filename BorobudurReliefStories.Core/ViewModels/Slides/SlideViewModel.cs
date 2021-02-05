namespace BorobudurReliefStories.Core.ViewModels.Slides
{
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.Services;
    using MvvmCross.ViewModels;

    public class SlideViewModel : MvxViewModel
    {
        private readonly IDeviceDisplayInfo _deviceDisplayInfo;

        public bool IsAChapterHeader => Path == null;

        public bool IsASlide => !IsAChapterHeader;

        public string Path { get; set; }

        public double HeightRequest => _deviceDisplayInfo.Width / 1000 * 312;

        public LocalizedString Name { get; set; }

        public LocalizedString Caption { get; set; }

        public SlideViewModel(IDeviceDisplayInfo deviceDisplayInfo)
        {
            _deviceDisplayInfo = deviceDisplayInfo;
        }
    }
}
