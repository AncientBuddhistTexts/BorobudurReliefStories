namespace BorobudurReliefStories.Core
{
    using MvvmCross.ViewModels;
    using BorobudurReliefStories.Core.ViewModels.Home;

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}
