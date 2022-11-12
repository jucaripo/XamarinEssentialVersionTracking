using System;
using System.Collections.Generic;
using versiontracking.ViewModels;
using versiontracking.Views;
using Xamarin.Forms;

namespace versiontracking
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

