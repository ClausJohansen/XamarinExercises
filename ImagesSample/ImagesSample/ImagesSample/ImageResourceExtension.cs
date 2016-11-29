using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImagesSample
{
    [ContentProperty("FileName")]
    class ImageResourceExtension : IMarkupExtension
    {
        public string FileName { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (FileName == null)
                return null;

            return ImageSource.FromResource(FileName);
        }
    }
}
