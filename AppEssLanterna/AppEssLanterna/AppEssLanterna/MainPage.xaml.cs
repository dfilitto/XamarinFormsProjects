using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppEssLanterna
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Boolean ligar;
        public MainPage()
        {
            InitializeComponent();
            ligar = false;
        }

        public async Task LigarCameraAsync(Boolean flag)
        {
            try
            {
                if (flag == true)
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
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
            }
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            ligar = !ligar;
            await this.LigarCameraAsync(ligar);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
