namespace BorobudurReliefStories.Core.Services
{
    using System.Collections.Generic;
    using BorobudurReliefStories.Core.Models;

    public interface IStoriesRepository
    {
        public IEnumerable<Story> GetStories();
    }
}
