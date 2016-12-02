using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleValueConverter.Converters
{
    class DoubleMultiplierConverter : IValueConverter
    {
        /// <summary>
        /// Convert from ViewModel to View
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine(value.GetType());

            if (System.Convert.ToDouble(value) != 0.0)
                return System.Convert.ToDouble(value) * 100;

            return false;

            /*
            var doubleValue = (double)value;
            return doubleValue * 100;
            */
        }


        /// <summary>
        /// Convert from View to ViewModel
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToDouble(value) != 0.0)
                return System.Convert.ToDouble(value) / 100;

            return false;

            /*
            var doubleValue = (double)value;
            return doubleValue / 100;
            */
        }
    }
}
