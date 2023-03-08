using System;
using Xamarin.Forms;

namespace iOSSpeakerVsEarpiece.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.AudioPlayer.Play();
        }
    }
}