using MvvmCross.IoC;
using MvvmCross.ViewModels;
using BorobudurReliefStories.Core.ViewModels.Home;

namespace BorobudurReliefStories.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}
