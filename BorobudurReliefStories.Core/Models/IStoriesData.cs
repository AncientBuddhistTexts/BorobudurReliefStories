namespace BorobudurReliefStories.Core.Models
{
    using System.Collections.Generic;

    public interface IStoriesData
    {
        public IEnumerable<Story> Load();
    }
}
