using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMinhaLanterna
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtLigar_Clicked(object sender, EventArgs e)
        {
            ImageButton bt = (ImageButton)sender;
            String texto = bt.Source.ToString();
            if(texto == "File: desligado")
            {
                bt.Source = "ligado";
                this.LigarCameraAsync(true);
            }
            else
            {
                bt.Source = "desligado";
                this.LigarCameraAsync(false);
            }
        }

        private void BtSite_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.dfilitto.com.br");
            Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private async void LigarCameraAsync(Boolean ligar)
        {
            try
            {
                if (ligar == true)
                {
                    // Turn On
                    await Flashlight.TurnOnAsync();
                }
                else
                {
                    // Turn Off
                    await Flashlight.TurnOffAsync();
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                await DisplayAlert("Erro", fnsEx.Message, "OK");
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                await DisplayAlert("Erro", pEx.Message, "OK");
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
