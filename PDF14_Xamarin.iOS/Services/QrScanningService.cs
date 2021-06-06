using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using PDF14_Xamarin.Services;
using System.Threading.Tasks;
using ZXing.Mobile;
using Xamarin.Forms;

//[assembly: Dependency(typeof(PDF14_Xamarin.iOS.Services.QrScanningService))]
namespace PDF14_Xamarin.iOS.Services
{
    //class QrScanningService: IQrScanningService
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