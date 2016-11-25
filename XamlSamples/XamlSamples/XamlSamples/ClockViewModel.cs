using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlSamples
{
    class ClockViewModel : INotifyPropertyChanged
    {
        private DateTime currentTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public ClockViewModel()
        {
            currentTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                CurrentTime = DateTime.Now;
                return true;
            });
        }

        public DateTime CurrentTime
        {
            set
            {
                if(currentTime != value)
                {
                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }

            get
            {
                return currentTime;
            }
        }
    }
}
