namespace BorobudurReliefStories.Core.Services
{
    public interface IAppSettingsService
    {
        public string Load(string key, string defaultValue);

        public void Save(string key, string value);
    }
}
