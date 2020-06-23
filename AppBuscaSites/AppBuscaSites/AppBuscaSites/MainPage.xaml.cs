using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBuscaSites
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<String> sites = new List<string>
        {
            "dfilitto.com.br","movieaholic.com.br","makeindiegames.com.br","bgdb.com.br","unoeste.br", "uol.com.br",
            "terra.com.br","facebook.com.br","youtube.com"
        };
        public MainPage()
        {
            InitializeComponent();
            ListaSites.ItemsSource = sites;
        }

        private void SearchSites_TextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = SearchSites.Text;
            ListaSites.ItemsSource = sites.Where(x=> x.ToLower().Contains(texto));
        }
    }
}
