namespace BorobudurReliefStories.Core
{
    using AutoMapper;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.ViewModels.Chapters;
    using BorobudurReliefStories.Core.ViewModels.Stories;

    public static class AutoMapperFactory
    {
        public static IMapper CreateMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Story, StoryViewModel>();
                cfg.CreateMap<Chapter, ChapterViewModel>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
