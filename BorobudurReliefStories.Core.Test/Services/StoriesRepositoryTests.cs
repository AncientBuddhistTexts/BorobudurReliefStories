namespace BorobudurReliefStories.Core.Test.Services
{
    using System;
    using System.Linq;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.Services;
    using FluentAssertions;
    using Xunit;

    public class StoriesRepositoryTests
    {
        [Fact]
        public void GetStories()
        {
            var stories = new StoriesRepository().GetStories();

            stories.Should().HaveCount(2);
            stories.ElementAt(1).Should().BeEquivalentTo(new Story
            {
                Id = "series2",
                Name = new LocalizedString
                {
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
                        Slides = new[] {
                            new Slide
                            {
                                Name = new LocalizedString
                                {
                                    En = "p1 - en",
                                    Id = "p1 - id",
                                },
                                Url = new Uri("/pic1.jpg", UriKind.Relative),
                                Caption = new LocalizedString
                                {
                                    En = "p1 - cap - en",
                                    Id = "p1 - cap - id",
                                },
                            }
                        },
                    },
                },
            });
        }
    }
}
