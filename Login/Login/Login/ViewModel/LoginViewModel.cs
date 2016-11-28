using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Login.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string versionText = "Version 1 komma nul dut!";
        private string statusText = "Indtast telefonnummer."; // Redundant, but I found no elegant way.
        private bool loginOk = false; // false is default, but lets be explicit.
        private string loginText;

        public string VersionText
        {
            get
            {
                return versionText;
            }

            set
            {
                if(value != versionText)
                {
                    versionText = value;
                    // Dont call OnPropertyChanged because this text is not meant to change at runtime.
                }
            }
        }

        public string StatusText
        {
            get
            {
                return statusText;
            }

            set
            {
                if (value != statusText)
                {
                    statusText = value;
                    OnPropertyChanged(nameof(StatusText));
                }
            }
        }

        public bool LoginOk
        {
            get
            {
                return loginOk;
            }

            set
            {
                if (value != loginOk)
                {
                    loginOk = value;

                    if (loginOk)
                        StatusText = "Klar til at logge ind.";
                    else
                        StatusText = "Indtast telefonnummer.";

                    OnPropertyChanged(nameof(LoginOk));
                }
            }
        }

        public string LoginText
        {
            get
            {
                return loginText;
            }

            set
            {
                if (value != loginText)
                {
                    loginText = value;
                    LoginOk = !String.IsNullOrEmpty(loginText);
                    OnPropertyChanged(nameof(LoginText));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            var localEvent = PropertyChanged;
            if(localEvent != null)
            {
                localEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
