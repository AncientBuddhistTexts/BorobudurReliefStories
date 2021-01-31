namespace BorobudurReliefStories.Core.Models
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;

    public class StoriesData : IStoriesData
    {
        public IEnumerable<Story> Load()
        {
            var opt = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };

            var stream = typeof(StoriesData).Assembly.GetManifestResourceStream($"{typeof(StoriesData).Namespace}.StoriesRepository.json");
            using var reader = new StreamReader(stream);
            return JsonSerializer.Deserialize<Story[]>(reader.ReadToEnd(), opt);
        }
    }
}
