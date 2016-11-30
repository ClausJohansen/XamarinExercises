using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using CustomRendererEntry;
using UIKit;
using CustomRendererEntry.iOS;

[assembly: ExportRenderer (typeof(CustomEntry), typeof(MyEntryRenderer))]
namespace CustomRendererEntry.iOS
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}