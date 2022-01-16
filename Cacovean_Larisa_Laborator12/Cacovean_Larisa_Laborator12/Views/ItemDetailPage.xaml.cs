using Cacovean_Larisa_Laborator12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Cacovean_Larisa_Laborator12.Views
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