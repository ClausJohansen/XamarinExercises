using SimpleValueConverter.ViewModel;

using Xamarin.Forms;

namespace SimpleValueConverter.View
{
    public partial class SlidePage : ContentPage
    {
        private SlideViewModel model;

        public SlidePage(SlideViewModel model)
        {
            this.model = model;
            BindingContext = this.model;
            InitializeComponent();
        }
    }
}
