namespace DR.CeritaReliefBorobudur.Core.Services
{
    public interface IAppSettingsService
    {
        public string Locale { get; set; }

        public bool FirstLaunch { get; set; }
    }
}
