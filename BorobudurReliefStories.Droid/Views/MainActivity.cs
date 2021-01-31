namespace BorobudurReliefStories.Droid
{
    using Android.App;
    using Android.OS;
    using MvvmCross.Forms.Platforms.Android.Views;
    using BorobudurReliefStories.Core.ViewModels.Main;
    using Android.Content.PM;

    [Activity(
        Theme = "@style/AppTheme",
        ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
        }
    }
}
