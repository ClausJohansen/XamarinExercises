using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlSamples
{
    public static class AppConstants
    {
        public static readonly Thickness pagePadding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

        public static readonly Font titleFont = Font.SystemFontOfSize(Device.OnPlatform(35, 40, 50), FontAttributes.Bold);

        public static readonly Color backgroundColor = Device.OnPlatform(Color.White, Color.Black, Color.Black);

        public static readonly Color ForegroundColor = Device.OnPlatform(Color.Black, Color.White, Color.White);
    }
}
