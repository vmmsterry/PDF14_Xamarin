using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDF14_Xamarin.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
