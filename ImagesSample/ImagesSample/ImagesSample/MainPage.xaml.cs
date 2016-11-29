using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImagesSample
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new LocalImages());
            Children.Add(new EmbeddedImages());
            Children.Add(new DownloadImages());
        }
    }
}
