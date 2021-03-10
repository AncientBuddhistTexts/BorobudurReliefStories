namespace DR.CeritaReliefBorobudur.Core.Services
{
    using System.Collections.Generic;
    using DR.CeritaReliefBorobudur.Core.Models;

    public interface IStoriesRepository
    {
        public IEnumerable<Story> GetStories();

        public IEnumerable<Chapter> GetChapters(string storyId);

        public IEnumerable<Slide> GetSlides(string storyId, string chapterId);

        public int GetInitialSlideIndex(string storyId, string chapterId);
    }
}
