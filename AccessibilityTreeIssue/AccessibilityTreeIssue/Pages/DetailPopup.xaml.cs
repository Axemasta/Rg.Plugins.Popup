using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace AccessibilityTreeIssue.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPopup : PopupPage
    {
        public DetailPopup()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync()
                .ConfigureAwait(false);
        }
    }
}
