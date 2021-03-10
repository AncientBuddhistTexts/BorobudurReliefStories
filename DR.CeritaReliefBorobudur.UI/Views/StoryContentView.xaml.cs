namespace DR.CeritaReliefBorobudur.UI.Views
{
    using DR.CeritaReliefBorobudur.Core.ViewModels.Stories;
    using MvvmCross.Forms.Views;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoryContentView : MvxContentView<StoryViewModel>
    {
        public StoryContentView()
        {
            InitializeComponent();
        }
    }
}
