namespace BorobudurReliefStories.Core.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using BorobudurReliefStories.Core.Models;

    public class StoriesRepository : IStoriesRepository
    {
        public IEnumerable<Story> Load()
        {
            var opt = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };

            var stream = typeof(StoriesRepository).Assembly.GetManifestResourceStream($"{typeof(StoriesRepository).Namespace}.StoriesRepository.json");
            using var reader = new StreamReader(stream);
            return JsonSerializer.Deserialize<Story[]>(reader.ReadToEnd(), opt);
        }
    }
}
