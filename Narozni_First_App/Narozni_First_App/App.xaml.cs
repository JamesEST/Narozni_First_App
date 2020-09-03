using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Narozni_First_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ValgusFoor();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
