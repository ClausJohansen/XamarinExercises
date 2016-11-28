using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using Login.ViewModel;

namespace Login.View
{
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel viewModel;

        public LoginPage(LoginViewModel viewModel)
        {
            this.viewModel = viewModel;
            BindingContext = this.viewModel;

            InitializeComponent();
        }
    }
}
