using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace versiontracking.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            // uso de version info
            nombreApp.Text = AppInfo.Name;
            versionInfo.Text = AppInfo.VersionString;

            // uso de version current Tracking
            versionTrack.Text = $"{VersionTracking.CurrentBuild} build ({VersionTracking.CurrentVersion}) version";

            versionPast.Text = $"{VersionTracking.PreviousBuild} build ({VersionTracking.PreviousVersion}) version";

            var listaBuildHistorial =  VersionTracking.BuildHistory;
            var listaVersionHistorial = VersionTracking.VersionHistory;

            var esPrimerArranque = VersionTracking.IsFirstLaunchForVersion("1.2.1");

        }
    }
}
