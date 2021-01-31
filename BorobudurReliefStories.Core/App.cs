namespace BorobudurReliefStories.Core
{
    using MvvmCross.ViewModels;
    using BorobudurReliefStories.Core.ViewModels.Home;
    using MvvmCross.IoC;

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
              .EndingWith("Repository")
              .AsInterfaces()
            .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
