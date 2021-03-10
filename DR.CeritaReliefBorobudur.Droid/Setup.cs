namespace DR.CeritaReliefBorobudur.Droid
{
    using DR.CeritaReliefBorobudur.Core.Services;
    using DR.CeritaReliefBorobudur.UI.Services;
    using MvvmCross;
    using MvvmCross.Forms.Platforms.Android.Core;

    public class Setup : MvxFormsAndroidSetup<Core.App, UI.App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterType<IAppSettingsService, AppSettingsService>();
        }
    }
}
