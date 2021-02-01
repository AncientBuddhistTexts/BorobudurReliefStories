namespace BorobudurReliefStories.Core
{
    using MvvmCross.ViewModels;
    using MvvmCross.IoC;
    using MvvmCross;
    using BorobudurReliefStories.Core.ViewModels.Stories;

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            Mvx.IoCProvider.RegisterSingleton(AutoMapperFactory.CreateMapper());

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<StoriesViewModel>();
        }
    }
}
