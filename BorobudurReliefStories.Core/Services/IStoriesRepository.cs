namespace BorobudurReliefStories.Core.Services
{
    using System.Collections.Generic;
    using BorobudurReliefStories.Core.Models;

    public interface IStoriesRepository
    {
        public IEnumerable<Story> GetStories();

        public IEnumerable<Chapter> GetChapters(string storyId);

        public IEnumerable<Slide> GetSlides(string storyId, string chapterId);
    }
}
