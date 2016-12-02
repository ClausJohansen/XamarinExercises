﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamlSamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new XamlSamples.MainPage();
            // MainPage = new SharedResourcesPage();
            // MainPage = new SliderBindingsPage();
            // MainPage = new SliderTransformsPage();
            // MainPage = new OneShotDateTimePage();
            MainPage = new ListViewDemoPage();
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
