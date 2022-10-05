using LestViewExample.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LestViewExample.Views
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