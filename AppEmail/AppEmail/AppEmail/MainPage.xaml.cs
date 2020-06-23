using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppEmail
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtEnviar_Clicked(object sender, EventArgs e)
        {
            //String rem = etReme.Text;
            String des = etDest.Text;
            String ass = etAssum.Text;
            String texto = etTexto.Text;

            String url = "mailto:" + des + "?subject=" + ass + "&body=" + texto;
            Device.OpenUri(new Uri(url));
        }
    }
}
