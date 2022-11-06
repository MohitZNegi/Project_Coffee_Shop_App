using Project_Coffee_Shop_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Project_Coffee_Shop_App.Views
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