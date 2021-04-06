namespace DR.CeritaReliefLalitavistara.UI.Services
{
    using DR.CeritaReliefLalitavistara.Core;
    using DR.CeritaReliefLalitavistara.Core.Services;

    public class DeviceDisplayInfo : IDeviceDisplayInfo
    {
        public double Width => App.MainScreenWidth;

        public double Height => App.MainScreenHeight;
    }
}
