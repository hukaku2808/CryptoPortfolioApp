using CryptoPortfolioApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CryptoPortfolioApp.Views
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