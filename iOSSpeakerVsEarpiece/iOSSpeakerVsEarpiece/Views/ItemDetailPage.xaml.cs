using iOSSpeakerVsEarpiece.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace iOSSpeakerVsEarpiece.Views
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