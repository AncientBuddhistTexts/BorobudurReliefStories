namespace BorobudurReliefStories.Core
{
    using System;
    using AutoMapper;
    using BorobudurReliefStories.Core.Models;

    public static class AutoMapperFactory
    {
        public static IMapper CreateMapper(Func<Type, object> resolver)
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.ConstructServicesUsing(resolver);
                cfg.CreateMap<Story, ViewModels.Stories.StoryViewModel>().ConstructUsingServiceLocator();
                cfg.CreateMap<Chapter, ViewModels.Chapters.ChapterViewModel>().ConstructUsingServiceLocator();
                cfg.CreateMap<Slide, ViewModels.Slides.SlideViewModel>().ConstructUsingServiceLocator();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
