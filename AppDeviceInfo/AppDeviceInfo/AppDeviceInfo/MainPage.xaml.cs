using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppDeviceInfo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Device Model (SMG-950U, iPhone10,6)
            var device = DeviceInfo.Model;
            etModel.Text = device;

            // Manufacturer (Samsung)
            var manufacturer = DeviceInfo.Manufacturer;
            etManifacture.Text = manufacturer;

            // Device Name (Motz's iPhone)
            var deviceName = DeviceInfo.Name;
            etName.Text = deviceName;

            // Operating System Version Number (7.0)
            var version = DeviceInfo.VersionString;
            etSO.Text = version;

            // Platform (Android)
            var platform = DeviceInfo.Platform;
            etPlatform.Text = platform.ToString();

            // Idiom (Phone)
            var idiom = DeviceInfo.Idiom;
            etIdiom.Text = idiom.ToString();

            // Device Type (Physical)
            var deviceType = DeviceInfo.DeviceType;
            etType.Text = deviceType.ToString();
        }
    }
}
