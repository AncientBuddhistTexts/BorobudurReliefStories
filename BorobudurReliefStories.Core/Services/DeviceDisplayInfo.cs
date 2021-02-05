namespace BorobudurReliefStories.UI.Services
{
    using BorobudurReliefStories.Core;
    using BorobudurReliefStories.Core.Services;

    public class DeviceDisplayInfo : IDeviceDisplayInfo
    {
        public double Width => App.MainScreenWidth;

        public double Height => App.MainScreenHeight;
    }
}
