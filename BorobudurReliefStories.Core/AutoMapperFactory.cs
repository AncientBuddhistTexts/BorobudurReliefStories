namespace BorobudurReliefStories.Core
{
    using System;
    using AutoMapper;
    using BorobudurReliefStories.Core.Models;
    using BorobudurReliefStories.Core.ViewModels.Chapters;
    using BorobudurReliefStories.Core.ViewModels.Stories;

    public static class AutoMapperFactory
    {
        public static IMapper CreateMapper(Func<Type, object> resolver)
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.ConstructServicesUsing(resolver);
                cfg.CreateMap<Story, StoryViewModel>().ConstructUsingServiceLocator();
                cfg.CreateMap<Chapter, ChapterViewModel>().ConstructUsingServiceLocator();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
