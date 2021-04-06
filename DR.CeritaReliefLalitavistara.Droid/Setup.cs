namespace DR.CeritaReliefLalitavistara.Droid
{
    using DR.CeritaReliefLalitavistara.Core.Services;
    using DR.CeritaReliefLalitavistara.UI.Services;
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
