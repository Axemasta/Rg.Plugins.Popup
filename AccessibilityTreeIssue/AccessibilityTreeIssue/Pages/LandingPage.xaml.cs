using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessibilityTreeIssue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessibilityTreeIssue.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        private bool _isNavigating;

        public LandingPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (_isNavigating)
                return;

            _isNavigating = true;

            try
            {
                var detailPage = new DetailPage()
                {
                    BindingContext = new DetailViewModel()
                };

                await Navigation.PushModalAsync(detailPage)
                    .ConfigureAwait(false);
            }
            finally
            {
                _isNavigating = false;
            }
        }
    }
}
