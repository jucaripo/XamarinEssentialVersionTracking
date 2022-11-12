using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using versiontracking.Services;
using versiontracking.Views;

namespace versiontracking
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            // iniciamos el control de Tracking de versiones
            Xamarin.Essentials.VersionTracking.Track();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

