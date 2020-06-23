using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppFalaMuito
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

        private async void btFalar_Clicked(object sender, EventArgs e)
        {
            String texto = etTexto.Text;
            //await TextToSpeech.SpeakAsync(texto);
            var settings = new SpeechOptions()
            {
                Volume = (float)slVolume.Value,
                Pitch = (float)slPitch.Value
            };

            await TextToSpeech.SpeakAsync(texto, settings);
        }

        private void slVolume_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int valor = (int)(100*slVolume.Value);
            lbVolume.Text = "Volume: "+valor.ToString();
        }

        private void slPitch_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbPitch.Text = "Pitch: " + slPitch.Value.ToString();
        }
    }
}