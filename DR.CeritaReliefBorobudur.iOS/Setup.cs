namespace DR.CeritaReliefBorobudur.iOS
{
    using DR.CeritaReliefBorobudur.Core.Services;
    using DR.CeritaReliefBorobudur.UI.Services;
    using MvvmCross;
    using MvvmCross.Forms.Platforms.Ios.Core;

    public class Setup : MvxFormsIosSetup<Core.App, UI.App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterType<IAppSettingsService, AppSettingsService>();
        }
    }
}
