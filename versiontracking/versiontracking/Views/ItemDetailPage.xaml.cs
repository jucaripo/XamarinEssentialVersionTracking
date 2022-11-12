using System.ComponentModel;
using Xamarin.Forms;
using versiontracking.ViewModels;

namespace versiontracking.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
