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

            Xamarin.Essentials.Platform.Init(this, bundle);

            Core.App.MainScreenHeight = Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density;
            Core.App.MainScreenWidth = Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density;
            Core.App.MainScreenDensity = Resources.DisplayMetrics.Density;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
