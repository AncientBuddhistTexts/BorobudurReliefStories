namespace DR.CeritaReliefLalitavistara.Core
{
    using System;
    using AutoMapper;
    using DR.CeritaReliefLalitavistara.Core.Models;
    using DR.CeritaReliefLalitavistara.Core.Services;

    public static class AutoMapperFactory
    {
        public static IMapper CreateMapper(Func<Type, object> resolver)
        {
            if (resolver is null)
            {
                throw new ArgumentNullException(nameof(resolver));
            }

            var appSettings = resolver(typeof(IAppSettingsService)) as IAppSettingsService;

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.ConstructServicesUsing(resolver);
                cfg.CreateMap<Story, ViewModels.Stories.StoryViewModel>().ConstructUsingServiceLocator();
                cfg.CreateMap<Chapter, ViewModels.Chapters.ChapterViewModel>().ConstructUsingServiceLocator();
                cfg.CreateMap<Slide, ViewModels.Slides.SlideViewModel>().ConstructUsingServiceLocator();
                cfg.CreateMap<LocalizedString, string>().ConvertUsing(ls => ls.ToString(appSettings));
            });

            return mapperConfiguration.CreateMapper();
        }

        private static string ToString(this LocalizedString @this, IAppSettingsService appSettings)
        {
            return appSettings.Locale == "en"
                ? @this?.En
                : appSettings.Locale == "id"
                    ? @this?.Id
                    : throw new NotImplementedException();
        }
    }
}
