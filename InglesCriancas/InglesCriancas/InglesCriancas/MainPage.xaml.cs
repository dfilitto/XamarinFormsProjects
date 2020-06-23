using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InglesCriancas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCores());
        }

        private void btNumeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageNumeros());
        }

        private void btFamilia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageFamilia());
        }

        private void btSair_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Device.BeginInvokeOnMainThread(async () =>
                //{
                //    var result = await this.DisplayAlert("Alert!", "want to exit?", "Yes", "No");
                //    if (result)
                //    {
                //        #if __ANDROID__
                //            var activity = (Android.App.Activity)Forms.Context;
                //            activity.FinishAffinity();
                //        #endif
                //        #if __IOS__
                //            Thread.CurrentThread.Abort();
                //        #endif
                //    }
                //});

                //DependencyService.Get<ICloseApplication>().closeApplication();
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch
            {
            }
        }
    }
}
