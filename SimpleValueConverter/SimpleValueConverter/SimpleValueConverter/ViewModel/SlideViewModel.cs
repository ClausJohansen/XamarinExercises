using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleValueConverter.ViewModel
{
    public class SlideViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double myValue;

        public double MyValue
        {
            get
            {
                return myValue;
            }

            set
            {
                if(value != myValue)
                {
                    myValue = value;
                    OnPropertyChanged();
                }
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var ev = PropertyChanged;

            if(ev != null)
                ev(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
