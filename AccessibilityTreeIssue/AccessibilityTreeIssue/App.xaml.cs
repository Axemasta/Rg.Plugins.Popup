using AccessibilityTreeIssue.Pages;
using AccessibilityTreeIssue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using XFApplication = Xamarin.Forms.Application;
using XFTabbedPage = Xamarin.Forms.TabbedPage;

namespace AccessibilityTreeIssue
{
    public partial class App : XFApplication
    {
        public App()
        {
            InitializeComponent();

            var landingPage = new LandingPage()
            {
                BindingContext = new LandingViewModel()
            };

            var landingNavPage = new NavigationPage(landingPage)
            {
                Title = landingPage.Title
            };

            var alternatePage = new AlternatePage()
            {
                BindingContext = new AlternateViewModel()
            };

            var alternateNavPage = new NavigationPage(alternatePage)
            {
                Title = alternatePage.Title
            };

            var tabbedPage = new XFTabbedPage();
            tabbedPage.Children.Add(landingNavPage);
            tabbedPage.Children.Add(alternateNavPage);

            tabbedPage.On<Android>()
                .SetToolbarPlacement(ToolbarPlacement.Bottom);

            tabbedPage.BarBackgroundColor = Color.FromHex("#4F5BD5");
            tabbedPage.BarTextColor = Color.White;

            MainPage = tabbedPage;
        }
    }
}
