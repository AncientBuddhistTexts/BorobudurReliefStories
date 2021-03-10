namespace DR.CeritaReliefBorobudur.UI.Services
{
    using DR.CeritaReliefBorobudur.Core;
    using DR.CeritaReliefBorobudur.Core.Services;

    public class DeviceDisplayInfo : IDeviceDisplayInfo
    {
        public double Width => App.MainScreenWidth;

        public double Height => App.MainScreenHeight;
    }
}
