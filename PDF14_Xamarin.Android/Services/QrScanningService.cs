using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PDF14_Xamarin.Services;
using ZXing.Mobile;

//[assembly: Xamarin.Forms.Dependency(typeof(PDF14_Xamarin.Droid.Services.QrScanningService))]

namespace PDF14_Xamarin.Droid.Services
{
    //class QrScanningService : IQrScanningService
    //{
    //    public async Task<string> ScanAsync()
    //    {
    //        var optionsDefault = new MobileBarcodeScanningOptions();
    //        var optionsCustom = new MobileBarcodeScanningOptions();

    //        var scanner = new MobileBarcodeScanner()
    //        {
    //            TopText = "Acerca la camara al elemento",
    //            BottomText = "Toca la pantalla para enfocar",
    //        };

    //        var scanResult = await scanner.Scan(optionsCustom);
    //        return scanResult.Text;
    //    }
    //}
}