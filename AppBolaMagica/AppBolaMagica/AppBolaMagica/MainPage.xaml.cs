using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppBolaMagica
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        SensorSpeed speed;
        List<ImageSource> imagens;
        public MainPage()
        {
            InitializeComponent();
            speed = SensorSpeed.UI;
            //Gyroscope.Start(speed);
            this.CriarRecursos();
            StartGyroscope(true);
            Gyroscope.ReadingChanged += Gyroscope_ReadingChanged;
        }

        private void Gyroscope_ReadingChanged(object sender, GyroscopeChangedEventArgs e)
        {
            Random r = new Random();
            GyroscopeData data = e.Reading;
            // Process Angular Velocity X, Y, and Z reported in rad/s
            //lbLogo.Text = $"Reading: X: {data.AngularVelocity.X}, Y: {data.AngularVelocity.Y}, Z: {data.AngularVelocity.Z}";
            float x = Math.Abs(data.AngularVelocity.X);
            float y = Math.Abs(data.AngularVelocity.Y);
            float z = Math.Abs(data.AngularVelocity.Z);
            if((x > 1) || (y > 1) || (z > 1))
            {
                imgBola.Source = imagens[r.Next(0, imagens.Count - 1)];
            }
        }

        private async void btSite_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.dfilitto.com.br");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        public void StartGyroscope(Boolean start)
        {
            try
            {
                if (start == false)
                    Gyroscope.Stop();
                else
                    Gyroscope.Start(speed);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
                DisplayAlert("Error", fnsEx.Message, "OK");
            }
            catch (Exception ex)
            {
                // Other error has occurred.
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
        private void CriarRecursos()
        {
            this.imagens = new List<ImageSource>();
            this.imagens.Add("bolachancenaoboa");
            this.imagens.Add("bolaconcentrese");
            this.imagens.Add("bolaconsulte");
            this.imagens.Add("boladeveser");
            this.imagens.Add("bolaestrela");
            this.imagens.Add("bolaestrelanao");
            this.imagens.Add("bolaimprovavel");
            this.imagens.Add("bolaindica");
            this.imagens.Add("bolamaistarde");
            this.imagens.Add("bolamtprovavel");
            this.imagens.Add("bolanao");
            this.imagens.Add("bolanaoaposte");
            this.imagens.Add("bolanaopodeagora");
            this.imagens.Add("bolanenhumaduvida");
            this.imagens.Add("bolaparecequesim");
            this.imagens.Add("bolaperspboa");
            this.imagens.Add("bolapodecontar");
            this.imagens.Add("bolapositivo");
            this.imagens.Add("bolapossivelagora");
            this.imagens.Add("bolasim");
        }
    }
}
