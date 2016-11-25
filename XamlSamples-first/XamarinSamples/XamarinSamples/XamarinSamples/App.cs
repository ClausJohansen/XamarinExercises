using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinSamples
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            // MainPage = new HelloXamlPage();
            // MainPage = new XamlPlusCodePage();
            // MainPage = new GridDemoPage();
            MainPage = new AbsoluteDemoPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
