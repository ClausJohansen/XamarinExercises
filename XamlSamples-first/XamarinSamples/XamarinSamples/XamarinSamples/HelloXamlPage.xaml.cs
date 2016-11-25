using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSamples
{
    public partial class HelloXamlPage : ContentPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();

            Rotate();
        }

        private async void Rotate()
        {
            while (true)
            {
                if (Label1.Rotation >= 360)
                    Label1.Rotation = 0;

                await Task.Factory.StartNew(() => {
                    Label1.Rotation += 10;
                });

                await Task.Delay(1); // It seems that the whole thing benifits from even a milliseconds "breather" between loops as to not max out the CPU.
            }
        }
    }
}
