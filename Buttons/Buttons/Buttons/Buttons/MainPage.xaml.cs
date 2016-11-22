using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Buttons
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_OnClick(object sender, EventArgs e)
        {
            Button invoker = (Button)sender;
            string inputCharacter = invoker.Text;

            if (string.IsNullOrEmpty(NumberLabel.Text))
                NumberLabel.Text = "";

            NumberLabel.Text += inputCharacter;
        }
    }
}
