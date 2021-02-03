namespace BorobudurReliefStories.Core
{
    using MvvmCross.ViewModels;
    using MvvmCross.IoC;
    using MvvmCross;
    using MvvmCross.Plugin;
    using System.Diagnostics.CodeAnalysis;

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            Mvx.IoCProvider.RegisterSingleton(AutoMapperFactory.CreateMapper(Mvx.IoCProvider.Resolve));

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterType<ViewModels.Stories.StoryViewModel, ViewModels.Stories.StoryViewModel>();
            Mvx.IoCProvider.RegisterType<ViewModels.Chapters.ChapterViewModel, ViewModels.Chapters.ChapterViewModel>();
            Mvx.IoCProvider.RegisterType<ViewModels.Slides.SlideViewModel, ViewModels.Slides.SlideViewModel>();

            RegisterAppStart<ViewModels.Stories.StoriesViewModel>();
        }

        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", Scope = "Method", MessageId = "0", Justification = "API called by framework.")]
        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            pluginManager.EnsurePluginLoaded<MvvmCross.Plugin.MethodBinding.Plugin>();
        }
    }
}
