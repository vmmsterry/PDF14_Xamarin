using PDF14_Xamarin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace PDF14_Xamarin
{
    public partial class MainPage : ContentPage
    {

		public MainPage() 
        {
            InitializeComponent();
        }
        	

        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScanPage());
        }
    }
}
