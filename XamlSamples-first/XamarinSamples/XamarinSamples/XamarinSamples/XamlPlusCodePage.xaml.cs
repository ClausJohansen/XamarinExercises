using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class XamlPlusCodePage : ContentPage
    {
        public XamlPlusCodePage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = e.NewValue.ToString("F3");
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            await DisplayAlert("Clicked!", "The button labeled '" + b.Text + "' has been clicked", "OK");
        }
    }
}
