using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HoraDoLanche
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.Text = "Hummm! Que gostoso!!!";
            foto.Source = "after_cookie";
            Device.OpenUri(new Uri("mailto:ryan.hatfield@test.com"));
        }
    }
}
