using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessibilityTreeIssue.ViewModels;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessibilityTreeIssue.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private bool _isNavigating;

        public DetailPage()
        {
            InitializeComponent();
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync()
                .ConfigureAwait(false);
        }

        private async void InfoButton_Clicked(object sender, EventArgs e)
        {
            if (_isNavigating)
                return;

            _isNavigating = true;

            try
            {
                var popup = new DetailPopup()
                {
                    BindingContext = new PopupViewModel()
                };

                await PopupNavigation.Instance.PushAsync(popup)
                    .ConfigureAwait(false);
            }
            finally
            {
                _isNavigating = false;
            }
        }
    }
}
