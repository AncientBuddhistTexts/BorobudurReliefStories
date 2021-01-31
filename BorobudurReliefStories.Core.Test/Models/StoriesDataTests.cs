namespace BorobudurReliefStories.Core.Test.Models
{
    using System;
    using System.Linq;
    using BorobudurReliefStories.Core.Models;
    using FluentAssertions;
    using Xunit;

    public class StoriesDataTests
    {
        [Fact]
        public void LoadRepository()
        {
            var stories = new StoriesData().Load();

            stories.Should().HaveCount(2);
            stories.ElementAt(1).Should().BeEquivalentTo(new Story
            {
                Id = "series2",
                Name = new LocalizedString{
                    En = "s2 - english",
                    Id = "s2 - bhasa",
                },
                Description = new LocalizedString
                {
                    En = "s2 - desc - english",
                    Id = "s2 - desc - bhasa",
                },
                Chapters = new[] {
                    new Chapter
                    {
                        Id = "1",
                        Name = new LocalizedString
                        {
                            En = "c1 - en",
                            Id = "c1 - id",
                        },
                        Photos = new[] {
                            new Photo
                            {
                                Name = new LocalizedString
                                {
                                    En = "p1 - en",
                                    Id = "p1 - id",
                                },
                                Url = new Uri("/pic1.jpg", UriKind.Relative),
                            }
                        },
                    },
                },
            });
        }
    }
}
