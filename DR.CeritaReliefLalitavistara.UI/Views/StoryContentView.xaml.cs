namespace DR.CeritaReliefLalitavistara.UI.Views
{
    using DR.CeritaReliefLalitavistara.Core.ViewModels.Stories;
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
